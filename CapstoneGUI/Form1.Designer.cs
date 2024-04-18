namespace CapstoneGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            slidePic = new PictureBox();
            lblTop = new Label();
            groupBox1 = new GroupBox();
            rBtnWomenShir = new RadioButton();
            rBtnShirt = new RadioButton();
            groupBox2 = new GroupBox();
            rBtnWomenPant = new RadioButton();
            rBtnMenPant = new RadioButton();
            groupBox3 = new GroupBox();
            rBtnWomenHat = new RadioButton();
            rBtnMenHat = new RadioButton();
            btnCalculate = new Button();
            btnClear = new Button();
            textBoxResult = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)slidePic).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // slidePic
            // 
            slidePic.Image = (Image)resources.GetObject("slidePic.Image");
            slidePic.Location = new Point(474, 127);
            slidePic.Name = "slidePic";
            slidePic.Size = new Size(319, 333);
            slidePic.TabIndex = 1;
            slidePic.TabStop = false;
            slidePic.Click += pictureBox2_Click;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTop.Location = new Point(536, 54);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(206, 38);
            lblTop.TabIndex = 2;
            lblTop.Text = "Clothing Store";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(rBtnWomenShir);
            groupBox1.Controls.Add(rBtnShirt);
            groupBox1.Location = new Point(58, 545);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rBtnWomenShir
            // 
            rBtnWomenShir.AutoSize = true;
            rBtnWomenShir.Location = new Point(12, 70);
            rBtnWomenShir.Name = "rBtnWomenShir";
            rBtnWomenShir.Size = new Size(152, 29);
            rBtnWomenShir.TabIndex = 1;
            rBtnWomenShir.TabStop = true;
            rBtnWomenShir.Text = "Women's Shirt";
            rBtnWomenShir.UseVisualStyleBackColor = true;
            // 
            // rBtnShirt
            // 
            rBtnShirt.AutoSize = true;
            rBtnShirt.Location = new Point(12, 15);
            rBtnShirt.Name = "rBtnShirt";
            rBtnShirt.Size = new Size(130, 29);
            rBtnShirt.TabIndex = 0;
            rBtnShirt.TabStop = true;
            rBtnShirt.Text = "Men's Shirt ";
            rBtnShirt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(rBtnWomenPant);
            groupBox2.Controls.Add(rBtnMenPant);
            groupBox2.Location = new Point(510, 545);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rBtnWomenPant
            // 
            rBtnWomenPant.AutoSize = true;
            rBtnWomenPant.Location = new Point(17, 70);
            rBtnWomenPant.Name = "rBtnWomenPant";
            rBtnWomenPant.Size = new Size(158, 29);
            rBtnWomenPant.TabIndex = 2;
            rBtnWomenPant.TabStop = true;
            rBtnWomenPant.Text = "Women's Pants";
            rBtnWomenPant.UseVisualStyleBackColor = true;
            // 
            // rBtnMenPant
            // 
            rBtnMenPant.AutoSize = true;
            rBtnMenPant.Location = new Point(17, 15);
            rBtnMenPant.Name = "rBtnMenPant";
            rBtnMenPant.Size = new Size(131, 29);
            rBtnMenPant.TabIndex = 1;
            rBtnMenPant.TabStop = true;
            rBtnMenPant.Text = "Men's Pants";
            rBtnMenPant.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(rBtnWomenHat);
            groupBox3.Controls.Add(rBtnMenHat);
            groupBox3.Location = new Point(1014, 545);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 150);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // rBtnWomenHat
            // 
            rBtnWomenHat.AutoSize = true;
            rBtnWomenHat.Location = new Point(6, 70);
            rBtnWomenHat.Name = "rBtnWomenHat";
            rBtnWomenHat.Size = new Size(144, 29);
            rBtnWomenHat.TabIndex = 2;
            rBtnWomenHat.TabStop = true;
            rBtnWomenHat.Text = "Women's Hat";
            rBtnWomenHat.UseVisualStyleBackColor = true;
            // 
            // rBtnMenHat
            // 
            rBtnMenHat.AutoSize = true;
            rBtnMenHat.Location = new Point(6, 15);
            rBtnMenHat.Name = "rBtnMenHat";
            rBtnMenHat.Size = new Size(117, 29);
            rBtnMenHat.TabIndex = 1;
            rBtnMenHat.TabStop = true;
            rBtnMenHat.Text = "Men's Hat";
            rBtnMenHat.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(398, 787);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(850, 787);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(420, 884);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(485, 31);
            textBoxResult.TabIndex = 8;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1376, 983);
            Controls.Add(textBoxResult);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTop);
            Controls.Add(slidePic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)slidePic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox slidePic;
        private Label lblTop;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rBtnWomenShir;
        private RadioButton rBtnShirt;
        private RadioButton rBtnWomenPant;
        private RadioButton rBtnMenPant;
        private GroupBox groupBox3;
        private RadioButton rBtnWomenHat;
        private RadioButton rBtnMenHat;
        private Button btnCalculate;
        private Button btnClear;
        private TextBox textBoxResult;
        private System.Windows.Forms.Timer timer1;
    }
}
