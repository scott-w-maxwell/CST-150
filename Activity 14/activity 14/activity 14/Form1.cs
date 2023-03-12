namespace activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check Answers
            
            // Q1.
            if(checkBox2.Checked && checkBox1.Checked) {
                label4.BackColor = Color.Green;
                label4.Text = "100% Correct";
                label4.Visible = true;
            }
            else if(checkBox1.Checked || checkBox2.Checked)
            {
                label4.BackColor = Color.Orange;
                label4.Text = "Partially Correct";
                label4.Visible= true;
            }
            else
            {
                label4.BackColor = Color.Red;
                label4.Text = "Incorrect";
                label4.Visible= true;
            }

            // Q2.
            if(radioButton2.Checked)
            {
                label5.BackColor = Color.Green;
                label5.Text = "100% Correct";
                label5.Visible= true;
            }
            else
            {
                label5.BackColor = Color.Red;
                label5.Text = "Incorrect";
                label5.Visible= true;
            }

            // Q3.
            if(listBox1.SelectedItem != null)
            {
                string selection = listBox1.SelectedItem.ToString();
                if (selection == "dataType[] arrayName;")
                {
                    label6.BackColor = Color.Green;
                    label6.Text = "100% Correct";
                    label6.Visible = true;
                }
                else
                {
                    label6.BackColor = Color.Red;
                    label6.Text = "Incorrect";
                    label6.Visible = true;
                }
            }
            else
            {
                label6.BackColor = Color.Red;
                label6.Text = "Incorrect";
                label6.Visible = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}