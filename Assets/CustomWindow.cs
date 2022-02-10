using UnityEditor;
using UnityEngine;



public class CustomWindow : EditorWindow
{

    [MenuItem("Window/Rooms Randomly")]
    public static void ShowWindow() //open window
    {
        EditorWindow.GetWindow<EditorWindow>("Rooms Randomly");
    }

    void onGUI()
    {
        //Window code put all code for it here
        GUILayout.Label("This is a label.", EditorStyles.boldLabel);
    }
}
