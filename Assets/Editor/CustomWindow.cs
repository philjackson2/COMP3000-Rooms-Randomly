using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomWindow : EditorWindow
{
	private UnityFolder Assets;
	private Vector2 Scroll;


	[MenuItem("Window/Rooms Randomly")]
	public static void ShowWindow()
	{
		GetWindow<CustomWindow>("Rooms Randomly");
	}

	
	void OnGUI()
	{

		GUILayout.Label("Rooms Randomly", EditorStyles.boldLabel);


		string notification1 = " You have spawned the baseroom";
		string notification2 = " You have spawned the pixel baseroom";
		string notification3 = " You have spawned a custom room";

		if (GUILayout.Button("Instantiate Base Room")) //if statement for button press will call on the specific object located in the recourcess
		{


			var EntryRoom = Resources.Load<GameObject>("Entry Room"); //takes the specific game object with that name and instatiates it on button press
			var RoomTemplate = Resources.Load<GameObject>("Room Templates");
			var Camera = Resources.Load<GameObject>("Main Camera");



			this.ShowNotification(new GUIContent(notification1)); //will show a notifcation stating that the base room has been spawned based off the earlier declared string

			Instantiate(EntryRoom);
			Instantiate(RoomTemplate);
			Instantiate(Camera);
		}



		if (GUILayout.Button("Instantiate Pixel Base Room")) //if statement for button press will call on the specific object located in the recourcess
		{


			var PixelEntryRoom = Resources.Load<GameObject>("Entry Room Pixel"); //takes the specific game object with that name and instatiates it on button press
			var PixelRoomTemplate = Resources.Load<GameObject>("Room Templates Pixel");
			var Camera = Resources.Load<GameObject>("Main Camera");


			this.ShowNotification(new GUIContent(notification2));


			Instantiate(PixelEntryRoom);
			Instantiate(PixelRoomTemplate);
			Instantiate(Camera);
		}



		if (GUILayout.Button("Instantiate Custom Room")) //if statement for button press will call on the specific object located in the recourcess
		{


			var CustomEntryRoom = Resources.Load<GameObject>("Custom Room"); 
			var CustomRoomTemplate = Resources.Load<GameObject>("Room Templates Cusom");
			var CustomCamera = Resources.Load<GameObject>("Main Camera Custom");


			this.ShowNotification(new GUIContent(notification3));


			Instantiate(CustomEntryRoom);
			Instantiate(CustomRoomTemplate);
			Instantiate(CustomCamera);
		}






		Scroll = GUILayout.BeginScrollView(Scroll);
		GUILayout.BeginVertical();


		GUILayout.BeginHorizontal();
		if (GUILayout.Button("find folders", EditorStyles.toolbarButton))
			Assets = new UnityFolder("Assets", null, 0, position);


		if (GUILayout.Button("Clear", EditorStyles.toolbarButton))
			Assets = null;
		GUILayout.EndHorizontal();

		if (Assets != null)
			Assets.VisualizeFolder();

		GUILayout.EndVertical();
		GUILayout.EndScrollView();


	}



}
