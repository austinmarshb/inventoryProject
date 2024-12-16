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
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            textBox2 = new TextBox();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            // button3
            // 
            button3.Location = new Point(468, 368);
            button3.Name = "button3";
            button3.Size = new Size(106, 45);
            button3.TabIndex = 4;
            button3.Text = "Delete Part";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // button5
            // 
            button5.Location = new Point(1074, 368);
            button5.Name = "button5";
            button5.Size = new Size(106, 45);
            button5.TabIndex = 7;
            button5.Text = "Delete Product";
            button5.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(895, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 10;
            // 
            // button8
            // 
            button8.Location = new Point(499, 85);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 11;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1105, 84);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 12;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 13;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1190, 556);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox2);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
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
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button5;
        private Button button7;
        private TextBox textBox2;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
