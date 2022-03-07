using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SomethingEditor : EditorWindow
{

    private static List<Object> objs = new List<Object>();
    private static List<float> floats = new List<float>();
    private static Vector2 v = Vector2.zero;

    [MenuItem("MenuItem/Test")]
    private static void DoIt() { EditorWindow.GetWindow<SomethingEditor>(); }

    void OnGUI()
    {
        EditorGUILayout.BeginScrollView(v);

        if (GUILayout.Button("Create an object"))
        {
            floats.Add(default(float));
            objs.Add(default(Object));
        }

        for (var i = 0; i < objs.Count; i++)
        {
            objs[i] = EditorGUILayout.ObjectField(objs[i], typeof(Object), false);
            floats[i] = EditorGUILayout.FloatField(floats[i]);
        }

        if (GUILayout.Button("Print"))
        {
            for (var i = 0; i < objs.Count; i++)
            {
                Debug.Log(objs[i]);
                Debug.Log(floats[i]);
            }
        }
        EditorGUILayout.EndScrollView();
    }
}