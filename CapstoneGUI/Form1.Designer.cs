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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTop = new Label();
            btnCalculate = new Button();
            pictureBox1 = new PictureBox();
            imagePicker = new ComboBox();
            button1 = new Button();
            ClotheBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClotheBox).BeginInit();
            SuspendLayout();
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTop.Location = new Point(519, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(236, 38);
            lblTop.TabIndex = 2;
            lblTop.Text = "Clothing Shoppe";
            lblTop.Click += lblTop_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(0, 0);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 151);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // imagePicker
            // 
            imagePicker.FormattingEnabled = true;
            imagePicker.Location = new Point(372, 258);
            imagePicker.Name = "imagePicker";
            imagePicker.Size = new Size(609, 33);
            imagePicker.TabIndex = 10;
            imagePicker.SelectedIndexChanged += imagePicker_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(614, 919);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClotheBox
            // 
            ClotheBox.Location = new Point(319, 306);
            ClotheBox.Name = "ClotheBox";
            ClotheBox.Size = new Size(662, 549);
            ClotheBox.TabIndex = 13;
            ClotheBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1376, 983);
            Controls.Add(ClotheBox);
            Controls.Add(button1);
            Controls.Add(imagePicker);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculate);
            Controls.Add(lblTop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClotheBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTop;
        private Button btnCalculate;
        private PictureBox pictureBox1;
        private ComboBox imagePicker;
        private Button button1;
        private PictureBox ClotheBox;
    }
}
