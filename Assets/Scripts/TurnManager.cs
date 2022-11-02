using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnManager : MonoBehaviour {
    public WindManager windManager;
    [SerializeField] private int turn = 1;

    [Header("Camera")]
    public GameObject camera1;
    public GameObject camera2;
    [Header("Cannon Movement & Firing")]
    public GameObject lookTarget1;
    public GameObject lookTarget2;
    public CannonballSpawner fire1;
    public CannonballSpawner fire2;
    [Header("Arrow Pointer")]
    public UIFollowWorldObject uiFollow;
    public Transform uiFollowTarget1;
    public Transform uiFollowTarget2;

    private void Start() {
        SetPlayerTurn(1);
        windManager.Randomize();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            NextTurn();
    }

    public void NextTurn() {
        turn += 1;
        windManager.Randomize();

        if (turn % 2 == 1) {
            SetPlayerTurn(1);
        } else {
            SetPlayerTurn(2);
        }
    }

    private void SetPlayerTurn(int playerID) {
        if (playerID == 1) {
            camera2.SetActive(false);
            camera1.SetActive(true);

            lookTarget1.SetActive(true);
            lookTarget2.SetActive(false);

            fire1.enabled = true;
            fire2.enabled = false;

            uiFollow.target = uiFollowTarget2; // should be the opposite player
        } else if (playerID == 2) {
            camera1.SetActive(false);
            camera2.SetActive(true);

            lookTarget1.SetActive(false);
            lookTarget2.SetActive(true);

            fire1.enabled = false;
            fire2.enabled = true;

            uiFollow.target = uiFollowTarget1;
        } else {
            Debug.Log("Player " + playerID + " doesn't exist.");
        }
    }

    public int GetPlayerID() {
        int id = turn % 2;
        if (id == 0)
            return 2;
        else
            return 1;
    }
}
