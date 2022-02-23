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



	}
}
