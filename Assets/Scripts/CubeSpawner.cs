using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    [SerializeField] GameObject cube;
    float zBound = 4.65f;
    float xBound = 4.7f;
    float yVal = 4.2f;

    float currentTimer = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > currentTimer) {
            currentTimer += 0.1f;
            SpawnCube();
        }
    }

    void SpawnCube() {
        float xVal = Random.Range(-xBound, xBound);
        float zVal = Random.Range(-zBound, zBound);

        GameObject newCube = Instantiate(cube, new Vector3(xVal, yVal, zVal), Random.rotation);
        newCube.GetComponent<Rigidbody>().useGravity = true;
    }
}
