using WGUC968.Classes;

namespace WGUC968
{
    partial class MainForm
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
            AddPartButton = new Button();
            ModifyPartButton = new Button();
            DeletePartButton = new Button();
            AddProductButton = new Button();
            ModifyProductButton = new Button();
            deleteProductButton = new Button();
            ExitButton = new Button();
            productSearchBox = new TextBox();
            partSearchButton = new Button();
            productSearchButton = new Button();
            partSearchBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PartsDataGrid = new DataGridView();
            ProductsDataGrid = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            clearPartSearch = new Button();
            clearProductSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(129, 368);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(106, 45);
            AddPartButton.TabIndex = 2;
            AddPartButton.Text = "Add Part";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // ModifyPartButton
            // 
            ModifyPartButton.Location = new Point(241, 368);
            ModifyPartButton.Name = "ModifyPartButton";
            ModifyPartButton.Size = new Size(106, 45);
            ModifyPartButton.TabIndex = 3;
            ModifyPartButton.Text = "Modify Part";
            ModifyPartButton.UseVisualStyleBackColor = true;
            ModifyPartButton.Click += ModifyPartButton_Click;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(353, 368);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(106, 45);
            DeletePartButton.TabIndex = 4;
            DeletePartButton.Text = "Delete Part";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += DeletePartButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(747, 368);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(106, 45);
            AddProductButton.TabIndex = 5;
            AddProductButton.Text = "Add Product";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ModifyProductButton
            // 
            ModifyProductButton.Location = new Point(859, 368);
            ModifyProductButton.Name = "ModifyProductButton";
            ModifyProductButton.Size = new Size(106, 45);
            ModifyProductButton.TabIndex = 6;
            ModifyProductButton.Text = "Modify Product";
            ModifyProductButton.UseVisualStyleBackColor = true;
            ModifyProductButton.Click += ModifyProductButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(971, 368);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(106, 45);
            deleteProductButton.TabIndex = 7;
            deleteProductButton.Text = "Delete Product";
            deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1109, 488);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(69, 56);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // productSearchBox
            // 
            productSearchBox.Location = new Point(812, 85);
            productSearchBox.Name = "productSearchBox";
            productSearchBox.Size = new Size(204, 23);
            productSearchBox.TabIndex = 10;
            // 
            // partSearchButton
            // 
            partSearchButton.Location = new Point(420, 85);
            partSearchButton.Name = "partSearchButton";
            partSearchButton.Size = new Size(75, 23);
            partSearchButton.TabIndex = 11;
            partSearchButton.Text = "Search";
            partSearchButton.UseVisualStyleBackColor = true;
            // 
            // productSearchButton
            // 
            productSearchButton.Location = new Point(1022, 85);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(75, 23);
            productSearchButton.TabIndex = 12;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // partSearchBox
            // 
            partSearchBox.Location = new Point(210, 85);
            partSearchBox.Name = "partSearchBox";
            partSearchBox.Size = new Size(204, 23);
            partSearchBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 15;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(618, 79);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 16;
            label3.Text = "Products";
            // 
            // PartsDataGrid
            // 
            PartsDataGrid.AllowUserToAddRows = false;
            PartsDataGrid.AllowUserToDeleteRows = false;
            PartsDataGrid.AllowUserToResizeColumns = false;
            PartsDataGrid.AllowUserToResizeRows = false;
            PartsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGrid.Location = new Point(12, 114);
            PartsDataGrid.MultiSelect = false;
            PartsDataGrid.Name = "PartsDataGrid";
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.Size = new Size(562, 248);
            PartsDataGrid.TabIndex = 17;
            // 
            // ProductsDataGrid
            // 
            ProductsDataGrid.AllowUserToAddRows = false;
            ProductsDataGrid.AllowUserToDeleteRows = false;
            ProductsDataGrid.AllowUserToResizeColumns = false;
            ProductsDataGrid.AllowUserToResizeRows = false;
            ProductsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGrid.Location = new Point(618, 114);
            ProductsDataGrid.MultiSelect = false;
            ProductsDataGrid.Name = "ProductsDataGrid";
            ProductsDataGrid.ReadOnly = true;
            ProductsDataGrid.Size = new Size(562, 248);
            ProductsDataGrid.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 512);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 19;
            label1.Text = "Austin Marsh C968 Task";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(420, 9);
            label4.Name = "label4";
            label4.Size = new Size(348, 32);
            label4.TabIndex = 21;
            label4.Text = "Inventory Management System";
            // 
            // clearPartSearch
            // 
            clearPartSearch.Location = new Point(499, 85);
            clearPartSearch.Name = "clearPartSearch";
            clearPartSearch.Size = new Size(75, 23);
            clearPartSearch.TabIndex = 23;
            clearPartSearch.Text = "Clear";
            clearPartSearch.UseVisualStyleBackColor = true;
            // 
            // clearProductSearch
            // 
            clearProductSearch.Location = new Point(1103, 85);
            clearProductSearch.Name = "clearProductSearch";
            clearProductSearch.Size = new Size(75, 23);
            clearProductSearch.TabIndex = 24;
            clearProductSearch.Text = "Clear";
            clearProductSearch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 556);
            Controls.Add(clearProductSearch);
            Controls.Add(clearPartSearch);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(ProductsDataGrid);
            Controls.Add(PartsDataGrid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(partSearchBox);
            Controls.Add(productSearchButton);
            Controls.Add(partSearchButton);
            Controls.Add(productSearchBox);
            Controls.Add(ExitButton);
            Controls.Add(deleteProductButton);
            Controls.Add(ModifyProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(DeletePartButton);
            Controls.Add(ModifyPartButton);
            Controls.Add(AddPartButton);
            Name = "MainForm";
            Text = "Inventory Management System Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPartButton;
        private Button ModifyPartButton;
        private Button DeletePartButton;
        private Button AddProductButton;
        private Button ModifyProductButton;
        private Button deleteProductButton;
        private Button ExitButton;
        private TextBox productSearchBox;
        private Button partSearchButton;
        private Button productSearchButton;
        private TextBox partSearchBox;
        private Label label2;
        private Label label3;
        private DataGridView PartsDataGrid;
        private DataGridView ProductsDataGrid;
        private Label label1;
        private Label label4;
        private Button clearPartSearch;
        private Button clearProductSearch;
    }
}
