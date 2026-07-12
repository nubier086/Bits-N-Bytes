namespace Bits_N_Bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            //HOME

          Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            //PRODUCT 

            PRODUCT product = new PRODUCT();
            product.Show();
            this.Hide();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            //ABOUT 
            About about = new About(); 
            about.Show();
            this.Hide();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //HOME LOGO




        }
    }
}
