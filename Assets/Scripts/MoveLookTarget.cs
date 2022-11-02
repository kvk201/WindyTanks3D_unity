using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLookTarget : MonoBehaviour {
    public float speed = 1f;
    public Vector2 horizontalBounds;
    public Vector2 verticalBounds;

    private void Update() {
        // calculation translation
        Vector2 translation = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        translation *= speed * Time.deltaTime;

        // translate
        transform.localPosition += (Vector3)translation;
        
        // clamp localPosition
        transform.localPosition = new Vector3(
            Mathf.Clamp(transform.localPosition.x, horizontalBounds.x, horizontalBounds.y),
            Mathf.Clamp(transform.localPosition.y, verticalBounds.x, verticalBounds.y),
            transform.localPosition.z
            );

    }
}
