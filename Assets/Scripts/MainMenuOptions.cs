using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {
    public void Quit() {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else    
                Application.Quit();
        #endif
    }

    public void ToGameScene() {
        SceneManager.LoadScene("Game Scene");
    }
}
