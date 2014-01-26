using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[InitializeOnLoad]
public class SMProHierarchyIcon : MonoBehaviour {
	static Texture2D icon;
    static List<int> markedObjects;
 
    static SMProHierarchyIcon ()
    {
       	icon = AssetDatabase.LoadAssetAtPath ("Assets/Gizmos/SoundManager Icon.png", typeof(Texture2D)) as Texture2D;
		if(icon == null)
			return;
       	EditorApplication.update += UpdateCB;
       	EditorApplication.hierarchyWindowItemOnGUI += HierarchyItemCB;
    }
 
    static void UpdateCB ()
    {
		if(icon == null)
			return;
       	
		GameObject[] go = Object.FindObjectsOfType (typeof(GameObject)) as GameObject[];
 
       	markedObjects = new List<int> ();
       	foreach (GameObject g in go) 
       	{
         	if (g.GetComponent<SoundManager> () != null)
         		markedObjects.Add (g.GetInstanceID ());
       	}
 
    }
 
    static void HierarchyItemCB (int instanceID, Rect selectionRect)
    {
		if(icon == null || markedObjects == null)
			return;
       	
		Rect r = new Rect (selectionRect); 
       	r.x = r.width-5;
		
       	if (markedObjects.Contains (instanceID)) 
       		GUI.Label (r, icon);
    }
}
