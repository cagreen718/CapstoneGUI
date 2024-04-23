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




        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { //Source:  //source:  https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0
            // Input Validation 
            if (rBtnShirt.Checked && rBtnMenHat.Checked)
            {
                decimal ShirHat = 62.99m;
                textBoxResult.Text = ShirHat.ToString();
            }
            if(rBtnShirt.Checked && rBtnWomenPant.Checked && rBtnWomenHat.Checked)
            {
                decimal WoManComb = 69.98m;
                textBoxResult.Text=WoManComb.ToString();
            }
            if (rBtnShirt.Checked && rBtnMenPant.Checked)
            {
                decimal ShirPant = 98.99m;
                textBoxResult.Text = ShirPant.ToString();
            }
            if (rBtnMenHat.Checked && rBtnMenPant.Checked)
            {
                decimal hatPant = 52.98m;
                textBoxResult.Text = hatPant.ToString();
            }
            if (rBtnShirt.Checked && rBtnMenHat.Checked && rBtnMenPant.Checked)
            {
                decimal comp = 103.12m;
                textBoxResult.Text = comp.ToString();
            }
            if (rBtnWomenShir.Checked && rBtnWomenPant.Checked && rBtnWomenHat.Checked)
            {
                decimal womComp = 172.73m;
                textBoxResult.Text = womComp.ToString();
            }
            if (rBtnWomenShir.Checked && rBtnMenPant.Checked && rBtnMenHat.Checked)
            {
                decimal WoComp = 105.32m;
                textBoxResult.Text=WoComp.ToString();   
            }
            if (rBtnWomenHat.Checked && rBtnWomenPant.Checked)
            {
                decimal womHapa = 52.99m;
                textBoxResult.Text = womHapa.ToString();
            }
            if (rBtnWomenShir.Checked && rBtnWomenPant.Checked)
            {
                decimal womShirPant = 45.78m;
                textBoxResult.Text =womShirPant.ToString();   
            }
            else
            {
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Source: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0

            //Source: https://stackoverflow.com/questions/20270547/c-sharp-calculating-decimal-numbers-from-textboxes
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

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //source: https://youtu.be/TsyddVNbXHk?si=Si58O0tZJRq7kk-4
            StreamReader sr = new StreamReader(@"C:\Users\user\source\repos\A7GUI\savings.txt");

            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            string[] mon = { y[0], y[2], y[4], y[6], y[8], y[10], y[12], y[14], y[16], y[18], y[20], y[22] };
            foreach (string s in mon)
            {
                comboBox1.Items.Add(s);
            }
        }
    }
}
