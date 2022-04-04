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
		
									
		if (GUILayout.Button("Instantiate Base Room")) //if statement for button press will call on the specific object located in the recourcess
		{


			var EntryRoom = Resources.Load<GameObject>("Entry Room"); //takes the specific game object with that name and instatiates it on button press
			var RoomTemplate = Resources.Load<GameObject>("Room Templates");
			var Camera = Resources.Load<GameObject>("Main Camera");
			Instantiate(EntryRoom);
			Instantiate(RoomTemplate);
			Instantiate(Camera);
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
