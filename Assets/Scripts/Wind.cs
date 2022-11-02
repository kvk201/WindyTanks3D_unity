using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {
    public Vector_3 windScriptable;
    public float minMag;
    public float maxMag;
    
    public Vector3 GetNextWind() {
        Vector3 wind = new Vector3();

        wind.x = Random.Range(-1f, 1f);
        wind.y = Random.Range(-1f, 0f);
        wind.z = Random.Range(-1f, 1f);

        wind = wind.normalized;
        
        float magnitude = Random.Range(minMag, maxMag);
        wind *= magnitude;

        windScriptable.value = wind;

        return wind;
    }
}
