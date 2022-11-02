using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHorizontal : MonoBehaviour {
    private void Update() {
        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hor);
    }
}
