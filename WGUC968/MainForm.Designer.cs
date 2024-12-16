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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            deletePartButton = new Button();
            button6 = new Button();
            button4 = new Button();
            deleteProductButton = new Button();
            button7 = new Button();
            productSearchBox = new TextBox();
            partSearchButton = new Button();
            productSearchButton = new Button();
            partSearchBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(244, 368);
            button1.Name = "button1";
            button1.Size = new Size(106, 45);
            button1.TabIndex = 2;
            button1.Text = "Add Part";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(356, 368);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 3;
            button2.Text = "Modify Part";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deletePartButton
            // 
            deletePartButton.Location = new Point(468, 368);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(106, 45);
            deletePartButton.TabIndex = 4;
            deletePartButton.Text = "Delete Part";
            deletePartButton.UseVisualStyleBackColor = true;
            deletePartButton.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(850, 368);
            button6.Name = "button6";
            button6.Size = new Size(106, 45);
            button6.TabIndex = 5;
            button6.Text = "Add Product";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(962, 368);
            button4.Name = "button4";
            button4.Size = new Size(106, 45);
            button4.TabIndex = 6;
            button4.Text = "Modify Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(1074, 368);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(106, 45);
            deleteProductButton.TabIndex = 7;
            deleteProductButton.Text = "Delete Product";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1109, 488);
            button7.Name = "button7";
            button7.Size = new Size(69, 56);
            button7.TabIndex = 8;
            button7.Text = "EXIT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // productSearchBox
            // 
            productSearchBox.Location = new Point(895, 85);
            productSearchBox.Name = "productSearchBox";
            productSearchBox.Size = new Size(204, 23);
            productSearchBox.TabIndex = 10;
            // 
            // partSearchButton
            // 
            partSearchButton.Location = new Point(499, 85);
            partSearchButton.Name = "partSearchButton";
            partSearchButton.Size = new Size(75, 23);
            partSearchButton.TabIndex = 11;
            partSearchButton.Text = "Search";
            partSearchButton.UseVisualStyleBackColor = true;
            partSearchButton.Click += button8_Click;
            // 
            // productSearchButton
            // 
            productSearchButton.Location = new Point(1105, 84);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(75, 23);
            productSearchButton.TabIndex = 12;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            productSearchButton.Click += productSearchButton_Click;
            // 
            // partSearchBox
            // 
            partSearchBox.Location = new Point(289, 85);
            partSearchBox.Name = "partSearchBox";
            partSearchBox.Size = new Size(204, 23);
            partSearchBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 15;
            label2.Text = "Parts";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(618, 79);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 16;
            label3.Text = "Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 248);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(618, 114);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(562, 248);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 512);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 19;
            label1.Text = "Austin Marsh C968 Task";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 194);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(420, 9);
            label4.Name = "label4";
            label4.Size = new Size(348, 32);
            label4.TabIndex = 21;
            label4.Text = "Inventory Management System";
            label4.Click += label4_Click;
            // 
            // button10
            // 
            button10.Location = new Point(408, 481);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 22;
            button10.Text = "TEST";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1190, 556);
            Controls.Add(button10);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(partSearchBox);
            Controls.Add(productSearchButton);
            Controls.Add(partSearchButton);
            Controls.Add(productSearchBox);
            Controls.Add(button7);
            Controls.Add(deleteProductButton);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(deletePartButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Inventory Management System Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button deletePartButton;
        private Button button6;
        private Button button4;
        private Button deleteProductButton;
        private Button button7;
        private TextBox productSearchBox;
        private Button partSearchButton;
        private Button productSearchButton;
        private TextBox partSearchBox;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button10;
    }
}
