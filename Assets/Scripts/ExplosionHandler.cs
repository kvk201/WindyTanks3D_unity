using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionHandler : MonoBehaviour {
    public float damageModifier = 1f;
    public HP hp;

    [SerializeField] private Collider selfCollider;
    [SerializeField] private CannonballSpawner spawner1;
    [SerializeField] private CannonballSpawner spawner2;
    [SerializeField] private Float BlastRadius;


    private void Start() {
        spawner1.firedDelegate += OnFiring;
        spawner2.firedDelegate += OnFiring;
    }

    private void OnFiring(Exploder exp) {
        exp.explosionDelegate += OnExplosion;
    }

    private void OnExplosion(Collider[] hits, Vector3 epicenter) {
        bool isDamaged = false;

        foreach (var hit in hits) {
            if (hit.name == selfCollider.name) {
                isDamaged = true;
            }
        }

        if (isDamaged) {
            Vector3 closestPoint = selfCollider.ClosestPoint(epicenter);
            float distance = Vector3.Distance(closestPoint, epicenter);
            distance = Mathf.Clamp(distance, 0f, Mathf.Infinity);
            float damage = GetDamageAmount(distance);
            hp.DoDamage(damage);
        }
    }

    private float GetDamageAmount(float distance) {
        float ratio = (BlastRadius.value - distance) / BlastRadius.value;
        return ratio * damageModifier;
    }
}
