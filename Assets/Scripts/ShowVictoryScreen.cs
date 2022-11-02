using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowVictoryScreen : MonoBehaviour {
    public GameObject gameOverPanel;
    public Text text;
    public TurnManager tm;
    public HP hp1;
    public HP hp2;

    private void Awake() {
        hp1.deathDelegate += DisplayVictoryScreen;
        hp2.deathDelegate += DisplayVictoryScreen;
    }

    public void DisplayVictoryScreen() {
        int playerID = tm.GetPlayerID();
        text.text = "Player " + playerID + "\nWINS";
        gameOverPanel.SetActive(true);
    }
}
