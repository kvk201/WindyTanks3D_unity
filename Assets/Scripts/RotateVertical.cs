using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVertical : MonoBehaviour {

    private void Update() {
        float ver = Input.GetAxis("Vertical");
        float hor = transform.rotation.x;
        transform.Rotate(Vector3.right, -ver);
    }
}
