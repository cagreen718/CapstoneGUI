namespace CapstoneGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //sorce for slider:  https://youtu.be/Ie09lhMEczU?si=BLNmPTHUz50mxYhl

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rBtnShirt.Checked &&rBtnMenHat.Checked)
            {
                decimal ShirHat = 62.99m;
                textBoxResult.Text = ShirHat.ToString();
            }
            if (rBtnShirt.Checked &&rBtnMenPant.Checked)
            {
                decimal ShirPant = 98.99m;
                textBoxResult.Text=ShirPant.ToString();
            }
            if (rBtnMenHat.Checked && rBtnMenPant.Checked)
            {
                decimal hatPant = 52.98m;
                textBoxResult.Text= hatPant.ToString();
            }
            if(rBtnShirt.Checked && rBtnMenHat.Checked && rBtnMenPant.Checked)
            {
                decimal comp = 103.12m;
                textBoxResult.Text=comp.ToString();
            }
            if((rBtnWomenShir.Checked &&rBtnWomenPant.Checked&&rBtnWomenHat.Checked))
            {
                decimal womComp = 172.73m;
                textBoxResult.Text= womComp.ToString();
            }
            if (rBtnWomenHat.Checked && rBtnWomenPant.Checked)
            {
                decimal womHapa = 52.99m;
                textBoxResult.Text = womHapa.ToString();    
            }
            else
            {
                MessageBox.Show("Options must be in Seperate Boxes");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Source: 
            rBtnMenHat.Checked = false;
            rBtnMenPant.Checked = false;
            rBtnShirt.Checked = false;
            rBtnWomenHat.Checked = false;
            rBtnWomenPant.Checked = false;
            rBtnWomenShir.Checked = false;
            textBoxResult.Clear();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
