# Attract Mode Video Demo
 A demo showing how to display an "Attract Mode" video demo when no one has interacted with the main menu for some time.

 Made using Unity 2017.1.5, but it should update to any newer version of Unity without issue. So please open the project with whatever version of Unity you are currently using assuming it is newer than 2017.1.5. 

 To start open the MainMenu scene in the "Scenes" folder.

 The project contains 2 scripts:
 	GoToAttractMode.cs
 	ReturnToMainMenu.cs

 GoToAttractMode.cs  Loads the AttractMode scene if the user has not interacted with the game in a set number of seconds.

 ReturnToMainMenue.cs Loads the MainMenu scene if the user interacts with the game.

 Both scripts make use of Input.anyKey to determine if any keyboard or controller input has been detected.
 If your project has a different way of detecting input, please substitute Input.anyKey for the equivalent boolean from your system.


 The AttractMode scene simply plays a video on loop. Playing video in Unity is easy, at least on PC. In this example, the Video Player is set to render to the main camera which simply plays the video full screen.

