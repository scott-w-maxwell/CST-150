using System.CodeDom;
using System.Reflection;
using System.Windows.Forms;

namespace Activity13
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Turn: x";
        }

        public void handlePress(Button button, int index1, int index2)
        {
            if (gameObj.inProgress && button.Text == "")
            {
                if (gameObj.turn == "x")
                {
                    // Set text
                    button.Text = "x";

                    // Set turn field and label to other player
                    gameObj.turn = "o";
                    label2.Text = "Turn: " + gameObj.turn;

                    // Set board field
                    gameObj.board[index1, index2] = "x";

                    // Increment turn count
                    gameObj.turnCount += 1;

                }
                else if (gameObj.turn == "o")
                {
                    // Set text
                    button.Text = "o";

                    // Set turn to other player
                    gameObj.turn = "x";
                    label2.Text = "Turn: " + gameObj.turn;

                    // Set board field
                    gameObj.board[index1, index2] = "o";

                    gameObj.turnCount += 1;
                }

                string winner = gameObj.checkWinner();
                if (winner == "Draw")
                {
                    label3.Text = "Winner: " + winner;
                    gameObj.inProgress = false;
                    label2.Text = "Turn: ";

                }
                else if (winner == "x")
                {
                    // Set winner label 
                    label3.Text = "Winner: " + winner;
                    gameObj.inProgress = false;
                    label2.Text = "Turn: ";


                }
                else if (winner == "o")
                {
                    // Set winner label
                    label3.Text = "Winner: " + winner;
                    gameObj.inProgress = false;
                    label2.Text = "Turn: ";
                }
            }
        }

        public string coinFlip()
        {
            // generate random number for first turn
            Random random = new Random();
            int coinFlip = random.Next(0, 2);

            if (coinFlip == 0)
            {
                return "x";
            }
            else
            {
                return "o";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handlePress(button1, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            handlePress(button2, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            handlePress(button3, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            handlePress(button4, 1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            handlePress(button5, 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            handlePress(button6, 1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            handlePress(button7, 2, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            handlePress(button8, 2, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            handlePress(button9, 2, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            // Create new game object
            label3.Text = "Winner:";
            gameObj.reset();
            gameObj.turn = coinFlip();
            gameObj.inProgress = true;
            label2.Text = "Turn: " + gameObj.turn;

            // Reset Button Text
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Initialize game object
        Game gameObj = new Game();
    }

    class Game
    {

        // Used to track if the game has begun
        public bool inProgress = true;

        // Used to keep track of turns (MAX 9 turns)
        public int turnCount = 0;

        // Stores if turn is "x" or "o" (default is x)
        public string turn = "x";

        // 2D array represents game board 
        public string[,] board = new string[3, 3]
        {
            {" ", " ", " " }, // [0, 0], [0, 1], [0, 2]
            {" ", " ", " " }, // [1, 0], [1, 1], [1, 2]
            {" ", " ", " " }  // [2, 0], [2, 1], [2, 2]
        };

        // Resets game object
        public void reset()
        {
            this.turnCount = 0;
            this.inProgress = true;

            // Loop through each index for the board and reset the value
            for (int index = 0; index < 3; index++)
            {
                for (int index2 = 0; index2 < 3; index2++)
                {
                    board[index, index2] = " ";
                }
            }


        }

        public string checkWinner()
        {


            if (this.turnCount <= 4)
            {
                return "No Winner";
            }

            string player;

            // Check each player 0 == 'o' and 1 == 'x'
            for (int playerIndex = 0; playerIndex < 2; playerIndex++)
            {
                if (playerIndex == 0)
                {
                    player = "o";
                }
                else
                {
                    player = "x";
                }

                for (int index = 0; index < 3; index++)
                {
                    // Horizontal wins
                    if (board[index, 0] == player && board[index, 1] == player && board[index, 2] == player)
                    {
                        return player;
                    }

                    // Vertical wins
                    if (board[0, index] == player && board[1, index] == player && board[2, index] == player)
                    {
                        return player;
                    }
                }

                // Diagonal win 1
                if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                {
                    return player;
                }

                // Diagonal win 2
                if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
                {
                    return player;
                }
            }

            // Placed after all other checks - if no winner determined after 9 turns, it is a tie
            if (this.turnCount >= 9)
            {
                return "Draw";
            }

            return "No Winner";
        }
    }

}