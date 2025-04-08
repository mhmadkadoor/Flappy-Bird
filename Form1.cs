using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        private int gravity = 1 ; // Gravity effect on the bird
        private int jumpStrength = -25; // Jump strength when the bird flaps
        private int pipeSpeed = 3; // Speed at which the pipes move
        private bool isGameOver = false; // Flag to check if the game is over
        private int score = 0; // Player's score

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown; // Handle key presses
            timer1.Interval = 20; // Set timer interval for smooth animation
            timer1.Tick += timer1_Tick; // Attach the timer tick event
            timer1.Start(); // Start the game loop
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return; // Stop updating if the game is over

            // Apply gravity to the bird
            birdPlayer.Top += gravity;

            // Move all pipes to the left
            MovePipes();

            // Check for collisions
            CheckCollisions();

            scoreLbl.Text = score.ToString(); // Update the score label

        }

        private void MovePipes()
        {
            
                
            pipUp1.Left -= pipeSpeed;
            pipLow1.Left -= pipeSpeed;
            pipUp2.Left -= pipeSpeed;
            pipLow2.Left -= pipeSpeed;
            pipUp3.Left -= pipeSpeed;
            pipLow3.Left -= pipeSpeed;
            pipUp4.Left -= pipeSpeed;
            pipLow4.Left -= pipeSpeed;
            pipUp5.Left -= pipeSpeed;
            pipLow5.Left -= pipeSpeed;
            pipUp6.Left -= pipeSpeed;
            pipLow6.Left -= pipeSpeed;

            // Reset pipe position if it goes off-screen
            if (pipLow1.Right <= 0) {
                pipLow1.Location = new Point(1150, 197);
                pipUp1.Location = new Point(1150, -98);
                score += 1; // Increment score
            }
            if (pipLow2.Right <= 0)
            {
                pipLow2.Location = new Point(1150, 238);
                pipUp2.Location = new Point(1150, -142);
                score += 1; // Increment score
            }
            if (pipLow3.Right <= 0)
            {
                pipLow3.Location = new Point(1150, 168);
                pipUp3.Location = new Point(1150, -168);
                score += 1; // Increment score
            }
            if (pipLow4.Right <= 0)
            {
                pipLow4.Location = new Point(1150, 238);
                pipUp4.Location = new Point(1150, -65);
                score += 1; // Increment score
            }
            if (pipLow5.Right <= 0)
            {
                pipLow5.Location = new Point(1150, 227);
                pipUp5.Location = new Point(1150, -129);
                score += 1; // Increment score
            }
            if(pipLow6.Right <= 0)
            {
                pipLow6.Location = new Point(1150, 145);
                pipUp6.Location = new Point(1150, -159);
                score += 1; // Increment score
            }





            }

        private void CheckCollisions()
        {
            // Check collision with top and bottom boundaries
            if (birdPlayer.Top < 0 || birdPlayer.Bottom > ClientSize.Height)
            {
                EndGame();
            }

            // Check collision with pipes
            
            if (birdPlayer.Bounds.IntersectsWith(pipUp1.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow1.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipUp2.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow2.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipUp3.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow3.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipUp4.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow4.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipUp5.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow5.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipUp6.Bounds) ||
                birdPlayer.Bounds.IntersectsWith(pipLow6.Bounds))
            {
                EndGame();
            }
                
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                // Make the bird jump
                birdPlayer.Top += jumpStrength;
            }
        }

        private void EndGame()
        {
            isGameOver = true;
            timer1.Stop();

            // Display a message box with options to quit or restart
            DialogResult result = MessageBox.Show("Game Over! Your score: " + score + "\nDo you want to restart?", "Game Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void RestartGame()
        {
            // Reset game state
            isGameOver = false;
            score = 0;
            scoreLbl.Text = score.ToString();
            birdPlayer.Location = new Point(83, 127);

            // Reset pipe positions
            pipUp1.Location = new Point(206, -98);
            pipLow1.Location = new Point(206, 197);
            pipUp2.Location = new Point(387, -142);
            pipLow2.Location = new Point(387, 238);
            pipUp3.Location = new Point(527, -168);
            pipLow3.Location = new Point(527, 168);
            pipUp4.Location = new Point(783, -65);
            pipLow4.Location = new Point(783, 238);
            pipUp5.Location = new Point(957, -129);
            pipLow5.Location = new Point(957, 227);
            pipUp6.Location = new Point(1150, -159);
            pipLow6.Location = new Point(1150, 145);


            timer1.Start();
        }
    }
}