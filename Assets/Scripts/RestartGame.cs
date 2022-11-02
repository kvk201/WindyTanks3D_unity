using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
    private void Update() {
        if (Input.GetKeyDown(KeyCode.R))
            RestartLevel();
        if (Input.GetKeyDown(KeyCode.P))
            GoToMainMenu();
    }

    private void GoToMainMenu() {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void RestartLevel() {
        SceneManager.LoadScene(1);
    }
}
