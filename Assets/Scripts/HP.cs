using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    public float maxHitPoints;
    public float currentHitPoints;

    public Action deathDelegate;

    private void Start() {
        currentHitPoints = maxHitPoints;
        
    }

    public void DoDamage(float amount) {
        currentHitPoints -= amount;
        if (IsDead()) Die();
    }

    private void Die() {
        if (deathDelegate != null)
            deathDelegate();
    }

    private bool IsDead() {
        if (currentHitPoints <= 0)
            return true;
         else
            return false;
    }
}
