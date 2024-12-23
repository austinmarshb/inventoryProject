using WGUC968.Classes;

namespace WGUC968
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            CancelButton = new Button();
            button3 = new Button();
            searchBox = new TextBox();
            candidatePartsGrid = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            minBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maxBox = new TextBox();
            priceBox = new TextBox();
            inventoryBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            associatedPartsGrid = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)candidatePartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(871, 562);
            button5.Name = "button5";
            button5.Size = new Size(64, 46);
            button5.TabIndex = 78;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(941, 562);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(64, 46);
            CancelButton.TabIndex = 77;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(645, 33);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 76;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(726, 29);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(166, 29);
            searchBox.TabIndex = 5;
            // 
            // candidatePartsGrid
            // 
            candidatePartsGrid.AllowUserToAddRows = false;
            candidatePartsGrid.AllowUserToDeleteRows = false;
            candidatePartsGrid.AllowUserToResizeColumns = false;
            candidatePartsGrid.AllowUserToResizeRows = false;
            candidatePartsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            candidatePartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidatePartsGrid.Location = new Point(345, 101);
            candidatePartsGrid.Name = "candidatePartsGrid";
            candidatePartsGrid.ReadOnly = true;
            candidatePartsGrid.Size = new Size(660, 173);
            candidatePartsGrid.TabIndex = 74;
            // 
            // button2
            // 
            button2.Location = new Point(643, 509);
            button2.Name = "button2";
            button2.Size = new Size(64, 46);
            button2.TabIndex = 73;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(643, 280);
            button1.Name = "button1";
            button1.Size = new Size(64, 46);
            button1.TabIndex = 72;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // minBox
            // 
            minBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minBox.Location = new Point(137, 350);
            minBox.Name = "minBox";
            minBox.Size = new Size(56, 29);
            minBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(94, 353);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 70;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(202, 350);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 69;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 315);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 68;
            label5.Text = "Price / Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 280);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 67;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 245);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 66;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 210);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 65;
            label2.Text = "ID";
            // 
            // maxBox
            // 
            maxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxBox.Location = new Point(247, 347);
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(56, 29);
            maxBox.TabIndex = 4;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(137, 312);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(166, 29);
            priceBox.TabIndex = 2;
            // 
            // inventoryBox
            // 
            inventoryBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryBox.Location = new Point(137, 277);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(166, 29);
            inventoryBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(137, 242);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(166, 29);
            nameBox.TabIndex = 0;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idBox.Location = new Point(137, 207);
            idBox.Name = "idBox";
            idBox.Size = new Size(166, 29);
            idBox.TabIndex = 16;
            // 
            // associatedPartsGrid
            // 
            associatedPartsGrid.AllowUserToAddRows = false;
            associatedPartsGrid.AllowUserToDeleteRows = false;
            associatedPartsGrid.AllowUserToResizeColumns = false;
            associatedPartsGrid.AllowUserToResizeRows = false;
            associatedPartsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            associatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsGrid.Location = new Point(345, 332);
            associatedPartsGrid.Name = "associatedPartsGrid";
            associatedPartsGrid.ReadOnly = true;
            associatedPartsGrid.Size = new Size(660, 171);
            associatedPartsGrid.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 58;
            label1.Text = "Modify Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 83);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 79;
            label8.Text = "All candidate parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(345, 312);
            label9.Name = "label9";
            label9.Size = new Size(201, 15);
            label9.TabIndex = 80;
            label9.Text = "All parts associated with this product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 626);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(CancelButton);
            Controls.Add(button3);
            Controls.Add(searchBox);
            Controls.Add(candidatePartsGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(minBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maxBox);
            Controls.Add(priceBox);
            Controls.Add(inventoryBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(associatedPartsGrid);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)candidatePartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button CancelButton;
        private Button button3;
        private TextBox searchBox;
        private DataGridView candidatePartsGrid;
        private Button button2;
        private Button button1;
        private TextBox minBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox maxBox;
        private TextBox priceBox;
        private TextBox inventoryBox;
        private TextBox nameBox;
        private TextBox idBox;
        private DataGridView associatedPartsGrid;
        private Label label1;
        private Label label8;
        private Label label9;
    }
}