using System;
using System.Windows.Forms;

namespace HashingPractice
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

        private void button1_Click(object sender, EventArgs e)
        {

            // Hash
            var hash = SecurePasswordHasher.Hash(pwInput.Text);

            HashedOutput.Text = hash.ToString();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hash
            var hash = SecurePasswordHasher.Hash(label1.Text);

            // Verify
            var result = SecurePasswordHasher.Verify(label1.Text, hash);

            if (result)
            {
                textBox2.Text = "Success!";
            }
            else
            {
                textBox2.Text = "FAIL!";

            }

            

        }
    }
}
