using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBallOnLeave : MonoBehaviour {
    private void OnTriggerExit(Collider other) {
        if (other.name == "Level Bounding Box")
            Destroy(gameObject);
    }
}
