namespace ExpenseTracker
{
    using System.Data;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    using Xceed.Document.NET;
    using Xceed.Words.NET;
    using ClosedXML.Excel;
    using PdfSharp.Pdf;
    using PdfSharp.Drawing;

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        /// <summary>
        /// DllImportAttribute allows you to call on unmanaged code from outside the program. Specifically dll files.
        /// user32.dll has most for the core Windows API in System32 Folder
        /// Windows forms uses user32.dll to create its form
        /// We are bypassing working with Windows Forms here to directly use the function it uses to move the window as a whole
        /// </summary>
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            CreateTable();
        }

        private void CreateTable()
        {
            dt = new DataTable();
            // Add Columns
            dt.Columns.Add("Months", typeof(string));
            dt.Columns.Add("Rent", typeof(double));
            dt.Columns.Add("Bills", typeof(double));
            dt.Columns.Add("Subscriptions", typeof(double));
            dt.Columns.Add("Groceries", typeof(double));
            dt.Columns.Add("Other", typeof(double));
            dt.Columns.Add("Total Expenses", typeof(double));
            dt.Columns.Add("Income", typeof(double));
            dt.Columns.Add("Gross Income", typeof(double));

            // Add Rows
            dt.Rows.Add("January", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("February", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("March", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("April", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("May", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("June", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("July", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("August", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("September", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("October", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("November", 0, 0, 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("December", 0, 0, 0, 0, 0, 0, 0, 0);

            DataGrid.DataSource = dt;

            DisableSorting();

        }

        private void DisableSorting()
        {
            foreach (DataGridViewColumn column in DataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButtonMouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(99, 95, 91);
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButtonMouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Transparent;
        }

        private void FileMouseEnter(object sender, EventArgs e)
        {
            File.BackColor = Color.FromArgb(99, 95, 91);
        }

        private void FileMouseLeave(object sender, EventArgs e)
        {
            File.BackColor = Color.Transparent;
        }

        private void EditTable(object sender, DataGridViewCellEventArgs e)
        {
            RowTotal(DataGrid.Rows[e.RowIndex]);
        }

        private void RowTotal(DataGridViewRow row)
        {
            double total = 0d;

            for (int i = 0; i < DataGrid.Columns.Count; i++)
            {
                if (i == DataGrid.Columns.Count - 3) break;
                if (double.TryParse(row.Cells[i].Value?.ToString(), out double cellValue))
                {
                    total += cellValue;
                }
            }

            row.Cells["Total Expenses"].Value = total.ToString();

            CalculateGrossIncome(row, total);
        }

        private void CalculateGrossIncome(DataGridViewRow row, double expenses)
        {
            double.TryParse(row.Cells["Income"].Value?.ToString(), out double income);
            row.Cells["Gross Income"].Value = income - expenses;

            if (income < expenses)
                row.Cells["Gross Income"].Style.BackColor = Color.Red;
            else
                row.Cells["Gross Income"].Style.BackColor = Color.Green;
        }

        private void File_Click(object sender, EventArgs e)
        {
            FileMenu.Show(File, new Point(0, File.Height));
        }

        private void ExportToWord_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExpenseTracker.docx";

            using (var document = DocX.Create(filePath))
            {
                document.InsertParagraph("Expense Tracker\n").FontSize(18).Bold().Alignment = Alignment.center;

                var table = document.AddTable(DataGrid.RowCount + 1, DataGrid.ColumnCount);
                table.Design = TableDesign.MediumGrid1Accent1;

                for (int i = 0; i < DataGrid.ColumnCount; i++)
                {
                    table.Rows[0].Cells[i].Paragraphs[0].Append(DataGrid.Columns[i].HeaderText);
                }

                for (int r = 0; r < DataGrid.RowCount; r++)
                {
                    for (int c = 0; c < DataGrid.ColumnCount; c++)
                    {
                        table.Rows[r + 1].Cells[c].Paragraphs[0].Append(DataGrid.Rows[r].Cells[c].Value?.ToString());
                    }
                }

                document.InsertTable(table);
                document.Save();
                Process.Start("explorer.exe", "/open, " + filePath);
            }
            MessageBox.Show($"Word document successfully created to {filePath}");
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExpenseTracker.xlsx";

            using (var workBook = new XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Sheet1");

                worksheet.Cell(1, 1).InsertTable(dt);

                worksheet.Columns().AdjustToContents();

                workBook.SaveAs(filePath);
            }
            MessageBox.Show($"Excel Document Successfully Created to {filePath}");
            Process.Start("explorer.exe", "/open, " + filePath);
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            MessageBox.Show("Please Enter Numbers Only!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }
    }
}
