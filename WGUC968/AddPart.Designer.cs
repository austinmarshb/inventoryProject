﻿namespace WGUC968
{
    partial class AddPart
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
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            minBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maxBox = new TextBox();
            machineOrCompanyBox = new TextBox();
            priceBox = new TextBox();
            inventoryBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            outsourcedRadioButton = new RadioButton();
            inHouseRadioButton = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(308, 406);
            button2.Name = "button2";
            button2.Size = new Size(83, 58);
            button2.TabIndex = 42;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(397, 406);
            button1.Name = "button1";
            button1.Size = new Size(83, 58);
            button1.TabIndex = 41;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 321);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 38;
            label8.Text = "Machine ID";
            label8.Click += label8_Click;
            // 
            // minBox
            // 
            minBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minBox.Location = new Point(210, 283);
            minBox.Name = "minBox";
            minBox.Size = new Size(56, 29);
            minBox.TabIndex = 4;
            minBox.TextChanged += minBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(167, 286);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 36;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 286);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 35;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 251);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 34;
            label5.Text = "Price / Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 216);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 33;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 181);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 32;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 146);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 31;
            label2.Text = "ID";
            // 
            // maxBox
            // 
            maxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxBox.Location = new Point(320, 283);
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(56, 29);
            maxBox.TabIndex = 5;
            maxBox.TextChanged += maxBox_TextChanged;
            // 
            // machineOrCompanyBox
            // 
            machineOrCompanyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineOrCompanyBox.Location = new Point(210, 318);
            machineOrCompanyBox.Name = "machineOrCompanyBox";
            machineOrCompanyBox.Size = new Size(166, 29);
            machineOrCompanyBox.TabIndex = 6;
            machineOrCompanyBox.TextChanged += machineOrCompanyBox_TextChanged;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(210, 248);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(166, 29);
            priceBox.TabIndex = 3;
            priceBox.TextChanged += priceBox_TextChanged;
            // 
            // inventoryBox
            // 
            inventoryBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryBox.Location = new Point(210, 213);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(166, 29);
            inventoryBox.TabIndex = 2;
            inventoryBox.TextChanged += inventoryBox_TextChanged;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(210, 178);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(166, 29);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idBox.Location = new Point(210, 143);
            idBox.Name = "idBox";
            idBox.Size = new Size(166, 29);
            idBox.TabIndex = 0;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outsourcedRadioButton.Location = new Point(289, 96);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(109, 25);
            outsourcedRadioButton.TabIndex = 24;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inHouseRadioButton.Location = new Point(175, 96);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(91, 25);
            inHouseRadioButton.TabIndex = 23;
            inHouseRadioButton.TabStop = true;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 45);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 43;
            label1.Text = "Add Part";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 501);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(minBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maxBox);
            Controls.Add(machineOrCompanyBox);
            Controls.Add(priceBox);
            Controls.Add(inventoryBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Name = "AddPart";
            Text = "Add Part";
            Load += AddPart_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox minBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox maxBox;
        private TextBox machineOrCompanyBox;
        private TextBox priceBox;
        private TextBox inventoryBox;
        private TextBox nameBox;
        private TextBox idBox;
        private RadioButton outsourcedRadioButton;
        private RadioButton inHouseRadioButton;
        private Label label1;
    }
}