//NAME: Varsan Jeyakkumar
//DATE: 2024-06-05 (Deadline)
//Title: PingPongSmart
/*
PURPOSE:
Through application of movement properties in windows form applications, the goal of the program is to design a Ping Pong Game
The game would be a single-player game with movement controlled by properties and some randomization/speed changes to make game fun
The game is not designed to be unbeatable, rather intentional error factors are imposed to ensure possibility of user winning
The user's best streak is constantly monitored by the counter as a streak, and the labels incentivize breaking this streak
*/

//Importations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongSmart___VJ
{
    public partial class Form1 : Form
    {
        /*Global Variable Declaration 
        This declares variables needed throughout the game and assigns initial values as needed.
        These variables are declared static so that they work throughout the form
        Many of these variables relate to the movement of the ball, but there are also booleans as controls and integers as trackers
        Random is also created in order to generate random numbers as needed throughout the program.
        */

        static Random randomClass = new Random(); //A random is created to allow random angles/directions to be generated

        static int intSpeed = 15; //Speed of the moving ball
        static int intDirection = randomClass.Next(1, 5); //Direction of the moving ball
        static int intHMove = intSpeed; //Horizontal Component
        static int intVMove = intSpeed; //Vertical Component
        static int intAngle = randomClass.Next(30, 61); //Angle of the ball moving 
        static bool boolIsUserMovable = false; //Boolean to enable/disable user movement
        static int intPaddleBounces = 0, intHigh = 0; //Keeps Count of Padddle Bounces and Overall High Score
        static int intComputerSlowDown = 0; //Factor to slow down the computer paddle
        static int intAutoLose = randomClass.Next(12, 21);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Form Loading
            When the form loads, the ball is automatically centered in the playing zone and in advance made visible to the user.
            */
            this.pblBall.Visible = true;
            this.pblBall.Left = (this.Width - this.pblBall.Width) / 2;
            this.pblBall.Top = (this.Height - this.pblBall.Height - this.pblBadZone.Height) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*Termination
            This code terminates the application and displays the users highest score just before closing the application
            */
            MessageBox.Show("BEST SCORE: " + intHigh);
            Application.Exit(); //Exits the application
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            //Message box display when user requests help during the game
            MessageBox.Show("Welcome to PingPongSmart - Designed By Varsan Jeyakkumar\nYou can control your paddle and move it (A left, D right)\nAfter you finish a game, you can reset it!\nGood LUCK!");
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e) //If a key is pressed, proceeds to move the user paddle
        {
            /*Key Down
            By clicking keys A and D, the user is able to move their paddle to make this game work.
            */
            if ((e.KeyCode == Keys.A) && (boolIsUserMovable == true)) //left
            {
                this.pblUserPaddle.Left -= 7;
            }
            if ((e.KeyCode == Keys.D) && (boolIsUserMovable == true)) //right
            {
                this.pblUserPaddle.Left += 7;
            }

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //Launches the timer and gives the initial message to the user
            MessageBox.Show("GOOD LUCK! (Use A and D to control your paddle)");
            this.tmrOne.Enabled = true; //Enables the timer
            this.btnBegin.Enabled = false; //user can not begin again as long as a game is running
            boolIsUserMovable = true; //allows the paddle to move
            this.pblBall.Visible = true; //makes ball visible

            
        }

        public int horizontalVal(int intHype, int intDegree)
        {
            /*FUNCTION
            Using the angle converted to radians, cosine ratio, and the hypotenuse value, this function returns the horizontal movement value
            */
            return (int)(intHype * Math.Cos((double)intDegree * Math.PI / 180));
        }
        public int verticalVal(int intHype, int intDegree)
        {
            /*FUNCTION
            Using the angle converted to radians, sine ratio, and the hypotenuse value, this function returns the vertical movement value
            */
            return (int)(intHype * Math.Sin((double)intDegree * Math.PI / 180));
        }

        private void tmrOne_Tick(object sender, EventArgs e)
        {

            //Gets horizontal and vertical moves using trignometric ratios
            if (intPaddleBounces == 0) //easy for the start
            {
                intHMove = horizontalVal(10, intAngle);
                intVMove = verticalVal(10, intAngle);
            }
            else
            {
                intHMove = horizontalVal(intSpeed, intAngle);
                intVMove = verticalVal(intSpeed, intAngle);
            }


            //Checks each direction, and using the principle of vectors (like positive negative in gr11 physics), assigns positive or negative
            if (intDirection == 1)
            {
                intHMove = Math.Abs(intHMove);
                intVMove = Math.Abs(intHMove) * -1;
            }
            else if (intDirection == 2)
            {
                intHMove = Math.Abs(intHMove) * -1;
                intVMove = Math.Abs(intHMove) * -1;
            }
            else if (intDirection == 3)
            {
                intHMove = Math.Abs(intHMove) * -1;
                intVMove = Math.Abs(intHMove);
            }
            else if (intDirection == 4)
            {
                intHMove = Math.Abs(intHMove);
                intVMove = Math.Abs(intHMove);
            }

            //displacement of the ball
            this.pblBall.Top += intVMove; //moves ball vertically
            this.pblBall.Left += intHMove; //moves ball horizontally

            //Computer movement
            int intComputerPaddleMove = 0; //declares a variable to declare how much the margin of error is for the movement
            if ((intPaddleBounces % 3 == 0)&&(intPaddleBounces>6))
            {
                intComputerSlowDown += 1; //increase a change factor which more significantly impacts the performance of the computer
            }
            if (randomClass.Next(1,3) == 1) //random selection of number 
            {
                intComputerPaddleMove = randomClass.Next(-3, 4); //bit bigger error margin
            }
            else
            {
                intComputerPaddleMove = randomClass.Next(-1, 2); //bit smaller error margin
            }
            
            if (randomClass.Next(1,3) == 2)
            {
                if (randomClass.Next(1,3) == 1 && intPaddleBounces > intAutoLose) //autolose would auto start glitching, enabling user to win easier
                {
                    this.pblComputerPaddle.Left += (intHMove + intComputerPaddleMove) + intComputerSlowDown;
                }
                else
                {
                    this.pblComputerPaddle.Left += (intHMove + intComputerPaddleMove);
                }
                
            }
            else
            {
                if (randomClass.Next(1, 3) == 1 && intPaddleBounces > intAutoLose) //autolose would auto start glitching, enabling user to win easier
                {
                    this.pblComputerPaddle.Left += (intHMove + intComputerPaddleMove) - intComputerSlowDown;
                }
                else
                {
                    this.pblComputerPaddle.Left += (intHMove + intComputerPaddleMove);
                }
            }


            //Bouncing of the ball on the paddles and the ends, alongside win and loss conditions
            //User Counter Clockwise
            if (intDirection == 3 && pblBall.Left < 0)
            {
                intDirection = 4;
                intAngle = randomClass.Next(0, 90); //updates angles
            }
            else if (intDirection == 2 && pblBall.Top < 0)
            {
                Win(); //win method
            }
            else if (intDirection == 1 && pblBall.Left > this.Width - this.pblBall.Width)
            {
                intDirection = 2;
                intAngle = randomClass.Next(-65, 70); //updates angles
            }
            else if (this.pblBall.Bounds.IntersectsWith(this.pblBadZone.Bounds))
            {
                Loss(); //loss method
            }

            //User Clockwise
            if (intDirection == 2 && pblBall.Left < 0)
            {
                intDirection = 1;
                intAngle = randomClass.Next(-65, 70); //updates angles
            }
            else if (intDirection == 1 && pblBall.Top < 0)
            {
                Win(); //win method
            }
            else if (intDirection == 4 && pblBall.Left > this.Width - this.pblBall.Width)
            {
                intDirection = 3;
                intAngle = randomClass.Next(-65, 70); //updates angles
            }
            else if (this.pblBall.Bounds.IntersectsWith(this.pblBadZone.Bounds))
            {
                Loss(); //loss method
            }

            if (this.pblBall.Bounds.IntersectsWith(this.pblUserPaddle.Bounds)) //if there is an intersection with the user paddle
            {
                for (int i = 0; i < randomClass.Next(1, 3); i++) //randomly increases speed by either one or two
                {
                    intSpeed++;
                }

                intPaddleBounces++; //increases paddle bounces counter
                this.lblGameScore.Text = "# of Paddle Bounces: " + intPaddleBounces; //adds to the paddle bounces label
                if (this.pblBall.Left > (this.pblUserPaddle.Left + this.pblUserPaddle.Width / 2)) //right side paddle
                {
                    intDirection = 1;

                    intAngle = randomClass.Next(-65, 70); //updates angles
                }
                if (this.pblBall.Left < (this.pblUserPaddle.Left + this.pblUserPaddle.Width / 2)) //left side paddle
                {
                    intDirection = 2;

                    intAngle = randomClass.Next(-65, 70); //updates angles
                }
            }

            if (this.pblBall.Bounds.IntersectsWith(this.pblComputerPaddle.Bounds)) //Runs if there is an intersection with the computer paddle bounds
            {
                if (intDirection == 1) //for computer paddle, only considers the direction
                {
                    intDirection = 4;
                    intAngle = randomClass.Next(-65, 70); //updates angles
                }
                if (intDirection == 2)
                {
                    intDirection = 3;
                    intAngle = randomClass.Next(-65, 70); //updates angles
                }
            }
        }

        private void Loss() 
        {
            //Method deals with the loss case
            this.tmrOne.Enabled = false;
            intSpeed = 0;
            intAngle = 0;

            MessageBox.Show("You lost to the computer! Try again and become better at PingPong =)");
            this.btnReset.Enabled = true;
            High();
        }

        private void Win()
        {
            //Method deals with the win case
            this.tmrOne.Enabled = false;
            intSpeed = 0;
            intAngle = 0;

            MessageBox.Show("You beat the computer! Congrats, can you beat your high score?");
            this.btnReset.Enabled = true;
            High();
        }

        private void Reset()
        {
            //Resets variables and labels
            this.pblBall.Visible = true;
            this.pblBall.Left = (this.Width - this.pblBall.Width) / 2;
            this.pblBall.Top = (this.Height - this.pblBall.Height - this.pblBadZone.Height) / 2;
            this.lblGameScore.Text = "# of Paddle Bounces: " + 0;
            intPaddleBounces = 0;
            intSpeed = 15;
            this.pblComputerPaddle.Left = (this.Width - this.pblComputerPaddle.Width) / 2;
            this.pblUserPaddle.Left = (this.Width - this.pblUserPaddle.Width) / 2;
            this.btnReset.Enabled = false;
            this.btnBegin.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset button click
            Reset(); //reset method
            MessageBox.Show("The game has been reset, you can now start game again!"); //informs user to begin the game again
        }

        private void High() //checks high score and does a pre-reset
        {
            //checks high score and does a pre-reset
            if (intHigh < intPaddleBounces) //HIGH SCORE comparison 
            {
                intHigh = intPaddleBounces; //If the high score is better, the high score value would change
            }
            this.lblHigh.Text = "HIGH SCORE: " + intHigh; //The value constanly refreshes at the end of the game with the current high score

            //Pre-Reset Changing
            this.pblBall.Top = 0; //moves the ball to (0,0), where the ball is frozen and invisible until program is reset
            this.pblBall.Left = 0;
            this.pblBall.Visible = false;
            MessageBox.Show("Press RESET to try again!"); //Directs user to redo
            boolIsUserMovable = false; //freezes the movement of the user paddle
            intComputerSlowDown = 0; //resets the slow-down factor
        }
    }
}


