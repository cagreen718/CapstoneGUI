namespace CapstoneGUI
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //source: https://youtu.be/lPBtgvoTjKc?si=jUsyG1iR6tHgs60s
            imagePicker.Items.Add("Shirt");
            imagePicker.Items.Add("Hat");
            imagePicker.Items.Add("Pants");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //source: https://youtu.be/t-4caAZKLJw?si=bORmNlbcwmBRT78q

            Form2 form = new Form2();
            form.Show();
        }

        private void imagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagePicker.SelectedItem == "Shirt")
            {
                var path = "C:\\Users\\user\\Downloads\\Shirt.jpeg";
                var imageLabel = Path.Combine(path);
                ClotheBox.ImageLocation= imageLabel;
            }

            if (imagePicker.SelectedItem == "Pants")
            {
                var path = "C:\\Users\\user\\Downloads\\Pants.jpg";
                var image=Path.Combine(path);
                ClotheBox.ImageLocation = image;
            }

            if(imagePicker.SelectedItem == "Hat")
            {
                var path = "C:\\Users\\user\\Downloads\\hat2.jpg";
                var imageLocation=Path.Combine(path);
                ClotheBox.ImageLocation = imageLocation;
            }

        }
    }
}
