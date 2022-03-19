using UnityEngine;
using UnityEditor;

public class CustomWindow : EditorWindow
{



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

			Instantiate(EntryRoom);
			Instantiate(RoomTemplate);
		}

	}
}
