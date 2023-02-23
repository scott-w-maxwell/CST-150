namespace Activity4
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            // Declare variable to output from string
            int userNum;

            // Try parsing string
            if (int.TryParse(userInput, out userNum))
            {
               
                if (userNum >= 60)
                {
                    int endResult = userNum / 60;
                    label2.Text = endResult.ToString() + " Minute(s)";
                }

                else if (userNum >= 3600)
                {
                    int endResult = userNum / 3600;
                    label2.Text = endResult.ToString() + " Hour(s)";
                }

                else if (userNum >= 86400)
                {
                    int endResult = userNum / 86400;
                    label2.Text = endResult.ToString() + " Day(s)";
                }
                else
                {
                    // Value entered by user is less than 60 (this also handles negatives which is nice)
                    label2.Text = "Value is too small";
                }
            }
            else
            {
                double userNums;
                // If number was too large for int type, convert the string into a Double
                if (double.TryParse(userInput, out userNums))
                {
                    double endResultDouble = Math.Floor((userNums / 86400));
                    label2.Text = endResultDouble.ToString() + " Day(s)";
                }
                else
                {
                    // Show user that their input was not valid.
                    label2.Text = "Invalid Input";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}