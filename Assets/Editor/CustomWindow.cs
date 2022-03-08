using UnityEngine;
using UnityEditor;

public class CustomWindow : EditorWindow
{

	string myString = "Hello World";
	

	[MenuItem("Window/Rooms Randomly")]
	public static void ShowWindow()
	{
		GetWindow<CustomWindow>("Rooms Randomly");
	}

	void OnGUI()
	{

		GUILayout.Label("Label Test", EditorStyles.boldLabel);

		myString = EditorGUILayout.TextField("Name", myString);//this the stuff for testing a text field. probably not relevant

		if (GUILayout.Button("Instantiate Base Room")) //if statement for button press will call on the specific object located in the recourcess
        {
			Debug.Log("Press Sucess");

			var EntryRoom = Resources.Load<GameObject>("Entry Room"); //takes the specific game object with that name and instatiates it on button press

			Instantiate(EntryRoom);
		}
		
	}
}
