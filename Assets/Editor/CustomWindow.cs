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

		if (GUILayout.Button("Press me"))
        {
			Debug.Log("Press Sucess");
        }

	}
}
