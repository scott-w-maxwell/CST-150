using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Open a Txt File",

                // Ensure files exist
                CheckFileExists = true,
                CheckPathExists = true,

                // Only allow .txt files
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = openFileDialog1.FileName;

                using (var reader = new StreamReader(@openFileDialog1.FileName))
                {
                    string textFile = reader.ReadToEnd();

                    // Lower Case everything
                    textFile = textFile.ToLower();

                    // Add lowercase file to textbox
                    textBox1.Text += "Lower Case: " + textFile;

                    // Create an array of all the words in the document
                    string[] wordsFromTextFile = textFile.Split(' ');

                    // Sort alphabetically
                    Array.Sort(wordsFromTextFile);

                    // Add first and last word alphabetically to textbox
                    textBox1.Text += "\r\nFirst Word: " + wordsFromTextFile[0] + "\r\nLast Word: " + wordsFromTextFile[wordsFromTextFile.Length - 1];

                    

                    // Returns # of vowels in a given string
                    int findVowels(string word)
                    {
                        string[] vowels = { "a", "e", "i", "o", "u" };

                        // For finding word with most vowels
                        int count = 0;
                        foreach (string vowel in vowels)
                        {
                            if (word.Contains(vowel))
                            {
                                count++;
                            }
                        }
                        return count;
                    }

                    string wordWithMostVowels = ""; 
                    string longestWord = "";
                    // Find the longest word in Array and word with most vowels
                    foreach (string word in wordsFromTextFile)
                    {
                        
                        // For finding largest Word
                        if (word.Length > longestWord.Length)
                        {
                            longestWord = word;
                        }


                        // For finding word with most vowels
                        if(findVowels(word) > findVowels(wordWithMostVowels))
                        {
                            wordWithMostVowels = word;
                        }
                    }

                    // Add Longest Word
                    textBox1.Text += "\r\nLongest Word: " + longestWord;

                    // Add Word with Most Vowels
                    textBox1.Text += "\r\nWord with most vowels: " + wordWithMostVowels;

                    // Set a variable to the Documents path.
                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    using (var writer = new StreamWriter(Path.Combine(documentsPath, "ouput.txt")))
                    {
                        writer.WriteLine(textBox1.Text);
                        label3.Text = "File Created here:" + Path.Combine(documentsPath, "ouput.txt");
                    }
                        

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}