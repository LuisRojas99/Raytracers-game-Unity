Requirements Specification for RayTracer’s Game.
	The purpose of the product “Raytracer’s Game” Is to entertain the user while the user is bored and has nothing else to do. The game would be designed to be as entertaining as possible, making the user engage for the longest time possible by making the user think about the solutions the puzzles will have.
The scope of the game has several features. Several levels or maps where the next map will always be harder than the last, making the puzzles harder every time the user completes the puzzle. It will have a ray tracing mechanism where only a bubble around the character is visible and everything else is darker (less visible). It will have buttons in the menu to access the different windows within the game, where it will have an about window, a settings window, and a start game button. Each window will have a back to main menu button to go back. It will have a main character which it will be at the center of the screen, the camera will follow the main character, and the main character will always look at the mouse cursor. It will not have a roguelike map generator system.
	The things we need to know to understand the documents are mesh, mesh filters, colliders, selectable, and (but not limited to) interactable.
	In the making of the videogame I have seen different tutorials:
https://www.youtube.com/watch?v=_VH7K8w3UHU&t=1184s&ab_channel=CodePlanStudio I watched all of the tutorials but did not implement all of it.
for tile maps :
https://www.youtube.com/watch?v=ryISV_nH8qw&t=118s&ab_channel=Brackeys
https://www.youtube.com/watch?v=1w5VEgXBo4E&t=551s&ab_channel=CodeMonkey
colliders :
https://www.youtube.com/watch?v=Cry7FOHZGN4&t=411s&ab_channel=CouchFerretmakesGames
Camera:
https://www.youtube.com/watch?v=GOQV688wbU0&t=301s&ab_channel=HundredFiresGames
Raytrace concept:
https://www.youtube.com/watch?v=U2ID-Psyg2U&t=156s&ab_channel=Guinxu

The context of this game will be to have it on your pc and play it whenever you feel to, or on your phone. 

The Diagram above is the way I have been developing my game for full resolution :
https://drive.google.com/file/d/1iyF88G8fmgMLYzznh5E4yXtqj58SaQNG/view?usp=sharing
The product Functions are the following : to be capable of have several menus within the main menu, each menu will display the correspondent information and options with a back button, the main menu will have a play button that will initiate the game changing the scene to the game scene. On the game scene will have a player character that will be able to open up chests and go through a puzzle and complete it.
The User Characteristics are that they have to be bored or willing to play the game, and their abilities will be to be able to count and make logical inferences to play a puzzle game with its rules.
The constraints of my system are that the player cnnot go out of bounds and cannot use other numbers that aren’t 1 through 9.
My System has a lot of assumptions and dependencies, like the scripts already provided by the Unity environment Ex. Rigidbody2D, Tilemapping, MainCamera.
Functional Requirements: https://github.com/LuisRojas99/Raytracers-game-Unity/blob/main/UserStories.md
NF.4.1.1:Interfaces : Selectable, 
The performance requirements are that :
	NF.4.2.1 : The sudoku generated should not take more than 15 seconds to be generated.
NF.4.2.2: The Player movement should be smooth, even if you rotate the mouse really fast, the game should not freeze.

NF.4.3.1 The player should be able to have a mouse and keyboard to play.
NF.4.4.1 Not much quality is expected. the system is not life critical.
