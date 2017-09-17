using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class TextFile {

	[MenuItem("Tools/Add Text File %t")]
	private static void CreateTextFile()
	{
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            StreamWriter myWriter = File.CreateText(Application.dataPath + "/NEW_TEXT.txt");
            Refresh();
        }
        else
        {
            StreamWriter myWriter = File.CreateText(Application.dataPath + "/NEW_TEXT.txt");
            Refresh();
        }
	}

    private static void Refresh(){
        AssetDatabase.Refresh();
    }
}
