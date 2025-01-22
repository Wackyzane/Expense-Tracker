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
            ExitButton = new Label();
            File = new Label();
            WindowDragBox = new Panel();
            DataGrid = new DataGridView();
            AddColumnButton = new Button();
            AddColumnName = new TextBox();
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
            File.Font = new Font("Segoe UI", 12F);
            File.ForeColor = Color.FromArgb(161, 161, 161);
            File.Location = new Point(10, 7);
            File.Name = "File";
            File.Size = new Size(34, 21);
            File.TabIndex = 1;
            File.Text = "File";
            File.MouseEnter += FileMouseEnter;
            File.MouseLeave += FileMouseLeave;
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
            DataGrid.BackgroundColor = Color.FromArgb(31, 31, 31);
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.GridColor = Color.FromArgb(161, 161, 161);
            DataGrid.Location = new Point(12, 71);
            DataGrid.Name = "DataGrid";
            DataGrid.Size = new Size(776, 367);
            DataGrid.TabIndex = 2;
            DataGrid.CellEndEdit += EditTable;
            // 
            // AddColumnButton
            // 
            AddColumnButton.Location = new Point(12, 42);
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.Size = new Size(84, 23);
            AddColumnButton.TabIndex = 3;
            AddColumnButton.Text = "Add Column";
            AddColumnButton.UseVisualStyleBackColor = true;
            AddColumnButton.Click += AddColumnClick;
            // 
            // AddColumnName
            // 
            AddColumnName.Location = new Point(102, 42);
            AddColumnName.Name = "AddColumnName";
            AddColumnName.Size = new Size(100, 23);
            AddColumnName.TabIndex = 4;
            AddColumnName.KeyDown += AddColumnEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(AddColumnName);
            Controls.Add(AddColumnButton);
            Controls.Add(DataGrid);
            Controls.Add(WindowDragBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowDragBox.ResumeLayout(false);
            WindowDragBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExitButton;
        private Label File;
        private Panel WindowDragBox;
        private DataGridView DataGrid;
        private Button AddColumnButton;
        private TextBox AddColumnName;
    }
}
