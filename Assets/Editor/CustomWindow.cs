using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;

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


		var splitView = new TwoPaneSplitView(0, 250, TwoPaneSplitViewOrientation.Horizontal);

		// Add the view to the visual tree by adding it as a child to the root element
		rootVisualElement.Add(splitView);

		// A TwoPaneSplitView always needs exactly two child elements
		var leftPane = new VisualElement();
		splitView.Add(leftPane);
		var rightPane = new VisualElement();
		splitView.Add(rightPane);


		if (GUILayout.Button("Instantiate Base Room")) //if statement for button press will call on the specific object located in the recourcess
		{


			var EntryRoom = Resources.Load<GameObject>("Entry Room"); //takes the specific game object with that name and instatiates it on button press
			var RoomTemplate = Resources.Load<GameObject>("Room Templates");

			Instantiate(EntryRoom);
			Instantiate(RoomTemplate);
		}

	}
}
