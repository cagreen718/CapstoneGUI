namespace CapstoneGUI
{
    partial class Form2
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
            label1 = new Label();
            ResulttxtBx = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            CalcBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(824, 28);
            label1.Name = "label1";
            label1.Size = new Size(301, 48);
            label1.TabIndex = 1;
            label1.Text = "Clothing Shoppe";
            // 
            // ResulttxtBx
            // 
            ResulttxtBx.Location = new Point(598, 917);
            ResulttxtBx.Name = "ResulttxtBx";
            ResulttxtBx.Size = new Size(850, 31);
            ResulttxtBx.TabIndex = 2;
            ResulttxtBx.TextChanged += ResulttxtBx_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(275, 476);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(877, 476);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 129);
            listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(1614, 476);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 129);
            listBox3.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(303, 541);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Men Shirt";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(892, 541);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pants";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(1623, 528);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 29);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Hat";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // CalcBTN
            // 
            CalcBTN.Location = new Point(916, 814);
            CalcBTN.Name = "CalcBTN";
            CalcBTN.Size = new Size(112, 34);
            CalcBTN.TabIndex = 9;
            CalcBTN.Text = "Calculate";
            CalcBTN.UseVisualStyleBackColor = true;
            CalcBTN.Click += CalcBTN_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2136, 1090);
            Controls.Add(CalcBTN);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(ResulttxtBx);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox ResulttxtBx;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button CalcBTN;
    }
}