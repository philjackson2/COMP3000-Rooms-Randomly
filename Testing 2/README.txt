--How to import-- 
Simply drag all folders into an empty scene in unity. There will be a short wait time whilst unity processes it. 


--How to Bring up the window--
Simply click on the 'window' tab and you will see 'rooms randomly' in the drop-down menu. Click on it and it will bring up the custom window. 


--How to use--
Once open you will see 3 buttons use to Spawn rooms,  'Instantiate Base Room', 'Instantiate Pixel Base Room' and 'Instantiate Custom room'. The first two are provided templates and examples of how this tool works and are included to help give you an understanding of how to use it.  

Once everything you have is loading in simply press the play button on the scene and watch it spawn in the dungeon!

-Base room-
The base room comes with a series of white box rooms and a boss at the end room. Each direction is loaded with 5 rooms each. There are no chests loaded in.


-Pixel Room-
The pixel room is more stylized and shows off being able to load in your own assets in. This room also comes pre-loaded with chests that spawn in. This works by going to 'Max Number of chests' and selecting the maximum number of chests you want to spawn in. It is set to 5 by default on this setting. 



-Customisation-
Finally try customizing it. By default the 'Instantiate Custom Room' is only set up to accept a game object with that exact name in the Resources folder. You can find a room set up with that name for you in the Custom Rooms folder provided. The same goes for the Room Templates game object with 'Custom' added to the end of it. Simply move or copy them into the Resources folder and press 'Instantiate Custom Room'. (When you do this make sure there is nothing in the scene as they may overlap it and make it look like you have not spawned it in. Keep an eye on the hierarchy) 

It should also spawn in a blank Room Templates for you to fill in with what you want. 
You can find the various rooms to fill them in with in the Prefabs folder. 
Each of these rooms is named after the direction their doors open in. 
When dragging them into the rooms section ensure they have a direction (look at the other rooms templates for an example on how to do so) 

The wait time is the amount of time that you want it to wait after running to spawn in in boss and chests. It is left open to change in the event that you want to spawn in many rooms as if you do this and the chests and boss spawn in before it is done generating it will not spawn beyond a certain point. 

You can find a chest icon in the pixel prefabs folder or feel free to import your own and use multiple! 

Finally set the maximum number of chests to however many you want. 

You dont need to touch anything else in the inspector as it will be overwritten as the code goes through it. 


--Find Folders--
Finally at the bottom of this you should see two buttons 'Show Folders' and 'Clear'. These are used to show assets within the folder within the window. This feature is currently being worked on and does not do anything other than show the items within folders. 