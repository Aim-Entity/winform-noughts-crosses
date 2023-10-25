namespace noughts_crosses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1 = textBox1.Text;
            string p2 = textBox2.Text;

            if(p1 == "" ||  p2 == "" )
            {
                MessageBox.Show("Enter all fields");
            }

            Form2 frm = new Form2(p1, p2);
            frm.Show();
        }
    }
}