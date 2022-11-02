using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFiring : MonoBehaviour {
    public int maxFiringTimes = 3;
    private int currentTimes;

    public TurnManager tm;
    public CannonballSpawner spawner;

    void Start() {
        spawner.firedDelegate += IncrementTime;
    }

    private void IncrementTime(Exploder exp) {
        currentTimes++;
        if (currentTimes >= maxFiringTimes) {
            currentTimes = 0;
            spawner.canFire = false;
            StartCoroutine(StartNextTurn());
        }
    }

    private IEnumerator StartNextTurn() {
        yield return new WaitForSeconds(2);
        spawner.canFire = true;
        tm.NextTurn();
    }
}
