using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;



namespace RunAndJump.LevelCreator
{
    public static class EditorUtils
    {
        //Create a New Scene for Use
        public static void NewScene()
        {
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
            EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
        }

        public static void NewLevel()
        {
            NewScene();

            //Create Level GameObject and assign the Level Component. 
            GameObject levelGO = new GameObject("Level");
            levelGO.transform.position = Vector3.zero;
            levelGO.AddComponent<Level>();
        }
    }
}
