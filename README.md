# Brief Description
Ping-Pong is a one-player game where a user can play a game of ping pong against the computer. This is a Windows Form Application programmed using C#. 

# How To Play
The program loads up with a ball and two paddles. The bottom paddle is keyboard controlled by the user (A and D) in order to stimulate left and right movement. Upon starting the game, the goal of the user is to prevent the ball from falling into the void. If the ball comes into contact with a paddle (bounds of paddle intersects the bounds of ball), it will bounce in a direction depending on where it hit. The ball increases speed every time the user paddle hits the ball. If the ball goes past the paddle, the side which it went past loses the game. The score is tabulated based on how many times the ball hits the user paddle. Upon the end, the user has an option to reset the game. 

# Computer Information
The computer paddle considers the ball's horizontal displacement when deciding which direction it should move in. This enables it to keep hitting the ball. However, this game is not designed to be unbeatable. At certain thresholds, the computer will automatically reduce how much it follows the horizontal displacement by using an error factor. This makes the game winnable. To make the game unwinnable by the user, this error factor can be removed. If this occurs, the computer will always win since its horizontal position is equivalent to the ball's at all times. Randomization and a counter were used to make this intentional error factor. 

# Windows Form Information
This code incorporates many features of windows form applications. It is not a simple console text based application, rather it has many moving components (visual components). The program uses information such as the position of picture boxes (based on top and left), intersection of bounds and labels to give tracking information to the user. Trignometic ratios and mathematical calculations helped determine the magnitudes of horizontal and vertical direction by the ball. A built in timer ensured the ball kept moving in a loop (served as a while true loop), enabling the game to constantly work. 
