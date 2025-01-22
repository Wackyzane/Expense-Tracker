namespace ExpenseTracker
{
    using System.Data;
    using System.Runtime.InteropServices;
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        /// <summary>
        /// DllImportAttribute allows you to call on unmanaged code from outside the program.
        /// user32.dll has most for the core Windows API in System32 Folder
        /// Windows forms uses user32.dll to create its form
        /// We are bypassing working with Windows Forms here to directly use the function it uses to move the window as a whole
        /// </summary>
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            CreateTable();
        }

        private void CreateTable()
        {
            DataTable dt = new DataTable();
            // Add Columns
            dt.Columns.Add("Months", typeof(string));
            dt.Columns.Add("Rent", typeof(double));
            dt.Columns.Add("Bills", typeof(double));
            dt.Columns.Add("Subscriptions", typeof(double));
            dt.Columns.Add("Groceries", typeof(double));
            dt.Columns.Add("Other", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            // Add Rows
            dt.Rows.Add("January", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("February", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("March", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("April", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("May", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("June", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("July", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("August", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("September", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("October", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("November", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("December", 0, 0, 0, 0, 0, 0);
            dt.Rows.Add("Total", 0, 0, 0, 0, 0, 0);
            DataGrid.DataSource = dt;
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToOrderColumns = true;
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

        private void AddColumnClick(object sender, EventArgs e)
        {
            AddColumnName.Text = string.Empty;
            CreateTable();
        }

        private void AddColumnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddColumnClick(sender, e);
            }
        }

        private void EditTable(object sender, DataGridViewCellEventArgs e)
        {
            RowTotal(DataGrid.Rows[e.RowIndex]);
            ColumnTotal(DataGrid.Columns[e.ColumnIndex]);
        }

        private void RowTotal(DataGridViewRow row)
        {
            double total = 0d;

            for (int i = 0; i < DataGrid.Columns.Count; i++)
            {
                if (i == DataGrid.Columns.Count - 1) continue;
                if (double.TryParse(row.Cells[i].Value?.ToString(), out double cellValue))
                {
                    total += cellValue;
                }
            }

            row.Cells["Total"].Value = total.ToString();
        }

        private void ColumnTotal(DataGridViewColumn column)
        {
            
        }
    }
}
