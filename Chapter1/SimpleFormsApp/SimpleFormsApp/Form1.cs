namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string fnameValue = firstName.Text;
            string lnameValue = lastName.Text;
            MessageBox.Show($"Hello World! {fnameValue} {lnameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
