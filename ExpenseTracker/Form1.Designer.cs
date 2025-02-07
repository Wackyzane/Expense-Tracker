namespace ExpenseTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ExitButton = new Label();
            File = new Label();
            FileMenu = new ContextMenuStrip(components);
            ExportMenuItem = new ToolStripMenuItem();
            wordToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            WindowDragBox = new Panel();
            DataGrid = new DataGridView();
            FileMenu.SuspendLayout();
            WindowDragBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.ForeColor = Color.FromArgb(161, 161, 161);
            ExitButton.Location = new Point(767, 7);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(19, 21);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.TextAlign = ContentAlignment.MiddleCenter;
            ExitButton.Click += ExitButtonClick;
            ExitButton.MouseEnter += ExitButtonMouseEnter;
            ExitButton.MouseLeave += ExitButtonMouseLeave;
            // 
            // File
            // 
            File.AutoSize = true;
            File.ContextMenuStrip = FileMenu;
            File.Font = new Font("Segoe UI", 12F);
            File.ForeColor = Color.FromArgb(161, 161, 161);
            File.Location = new Point(10, 7);
            File.Name = "File";
            File.Size = new Size(34, 21);
            File.TabIndex = 1;
            File.Text = "File";
            File.Click += File_Click;
            File.MouseEnter += FileMouseEnter;
            File.MouseLeave += FileMouseLeave;
            // 
            // FileMenu
            // 
            FileMenu.Items.AddRange(new ToolStripItem[] { ExportMenuItem });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(109, 26);
            // 
            // ExportMenuItem
            // 
            ExportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordToolStripMenuItem, excelToolStripMenuItem });
            ExportMenuItem.Name = "ExportMenuItem";
            ExportMenuItem.Size = new Size(108, 22);
            ExportMenuItem.Text = "Export";
            // 
            // wordToolStripMenuItem
            // 
            wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            wordToolStripMenuItem.Size = new Size(103, 22);
            wordToolStripMenuItem.Text = ".docx";
            wordToolStripMenuItem.Click += ExportToWord_Click;
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(103, 22);
            excelToolStripMenuItem.Text = ".xlsx";
            excelToolStripMenuItem.Click += ExportToExcel_Click;
            // 
            // WindowDragBox
            // 
            WindowDragBox.BackColor = Color.Transparent;
            WindowDragBox.Controls.Add(File);
            WindowDragBox.Controls.Add(ExitButton);
            WindowDragBox.Location = new Point(2, 2);
            WindowDragBox.Name = "WindowDragBox";
            WindowDragBox.Size = new Size(798, 34);
            WindowDragBox.TabIndex = 2;
            WindowDragBox.MouseDown += DragWindow;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToOrderColumns = true;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGrid.BackgroundColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.GridColor = Color.FromArgb(161, 161, 161);
            DataGrid.Location = new Point(12, 71);
            DataGrid.Name = "DataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.ForeColor = Color.White;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.Size = new Size(776, 367);
            DataGrid.TabIndex = 2;
            DataGrid.CellEndEdit += EditTable;
            DataGrid.DataError += DataError;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(DataGrid);
            Controls.Add(WindowDragBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            FileMenu.ResumeLayout(false);
            WindowDragBox.ResumeLayout(false);
            WindowDragBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ExitButton;
        private Label File;
        private Panel WindowDragBox;
        private DataGridView DataGrid;
        private ContextMenuStrip FileMenu;
        private ToolStripMenuItem ExportMenuItem;
        private ToolStripMenuItem wordToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
    }
}
