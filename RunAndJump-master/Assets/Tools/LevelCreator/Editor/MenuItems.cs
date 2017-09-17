using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;


namespace RunAndJump.LevelCreator {
    public static class MenuItems {

        [MenuItem("Tools/Level Creator/New Level Scene %L")]
        private static void NewLevel()
        {
            EditorUtils.NewLevel();
        }

    }
}
