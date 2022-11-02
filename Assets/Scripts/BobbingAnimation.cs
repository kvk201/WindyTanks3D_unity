using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingAnimation : MonoBehaviour {
    public float amplitude = 1f;
    public float speed = 1f;

    public Vector3 GetBobOffset(Vector3 direction, bool normalized = true) {
        if (normalized)
            direction = direction.normalized;
        return direction * Mathf.Sin(speed * Time.time) * amplitude;
    }
}
