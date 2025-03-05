namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnameValue = firstName.Text;
            string lnameValue = lastName.Text;
            string mnameValue = middleName.Text;
            string suffixValue = suffix.Text;

           DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                MessageBox.Show($"Hello There!{fnameValue}  {lnameValue} {mnameValue} {suffixValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
    }
}
