--How to import-- 
Simply drag all folders into an empty scene in unity. There will be a short wait time whilst unity processes it. 


--How to Bring up the window--
Simply click on the 'window' tab and you will see 'rooms randomly' in the dropdown menu. Click on it and it will bring up the custom window. 


--How to use--
There are 3 buttons. 'Instantiate baseroom', 'Find folders' and 'Clear folders'. 
Instantiate baseroom loads the base room in the centre of the scene.
Find folders brings up a list of all folders in your folder 
Clear folders clears them. 

Once the base room is instatiate you should see in the heirarchy a prefab called 'Room templates' This has come base loaded with rooms to 
generate. 
Within this script are 4 parameters Bottom, Top, Left and Right rooms. Within here you can add  the types of rooms that you want spawned in that
direction. The base loaded rooms have doors in that direction to ensure that there are no duds. 

You also have a closed room and boss to signify and end to the dungeon. 


Finally there is the 'Wait Time'. This is how long you want it to run for generating rooms.

Once everything is set up simply run the scene and the randomised dungeon will be generated. 

--Customisation-- 
You can change the base room that is instantiated by going into the 'Resources' folder and adding your base room and calling it 'Entry Room'
Make sure you attach both the 'Add Room' script and Spawn points. Both of witch can be obtained from the default entry room. 
For the other rooms you can load those into the room templates prefab and everything will be sorted. 