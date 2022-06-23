# TicTacToe
It's my first project written in C#.
In the most popular version, the game takes place on a 3x3 board. Two players alternately place their characters in the spaces, trying to occupy three spaces in a line. The player is assigned a cross (X) or a circle (O) sign. One field can be occupied by one player and does not change throughout the course of the game.

This solution contains two projects. One in a simple Console Application and the other is a Windows Forms application. Both has the same main logic which can be found in Game class where winner is being determined by checking current state of game board after each players move. Game board is represented by 2-dimension array which stores players marks. In console version game process is a loop of reading players inputs indicating coordinates to put their mark, until there is a winner or board is full (tie). Windows Forms one is wrapped around click events on buttons representing board fields.

![WinForms1](https://user-images.githubusercontent.com/97447088/175339673-93ef5a2e-1154-4e6f-a1fd-e576b8b19bd9.png)
![WinForms2](https://user-images.githubusercontent.com/97447088/175339685-d36be6fb-e3b9-4d4b-ad67-a3fbfb1a623b.png)
![WinForms3](https://user-images.githubusercontent.com/97447088/175339692-8ca0ac5a-f1f2-4b40-be95-c85ecd6f5122.png)
![WinForms4](https://user-images.githubusercontent.com/97447088/175339705-c51f505d-ba47-4739-8507-bbdf787efcf8.png)
