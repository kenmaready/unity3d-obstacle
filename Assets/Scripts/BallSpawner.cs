using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] GameObject ball;
    float xMinBound = -4.85f;
    float xMaxBound = 4.85f;
    float z1MinBound = 6.3f;
    float z1MaxBound = 7.54f;
    float z2MinBound = -7.55f;
    float z2MaxBound = -6.35f;
    float zSpread;
    float yVal = 4.2f;

    float currentTimer = 0;

    void Awake() {
        zSpread = (z1MaxBound - z1MinBound) + (z2MaxBound - z2MinBound);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > currentTimer) {
            currentTimer += 0.4f;
            SpawnCube();
        }
    }

    void SpawnCube() {
        float xVal = Random.Range(xMinBound, xMaxBound);
        float zVal = Random.Range(z2MinBound, z2MinBound + zSpread);
        if (zVal > z2MaxBound) {
            zVal = (zSpread - (z2MaxBound - z2MinBound)) + z1MinBound;
        }

        GameObject newBall = Instantiate(ball, new Vector3(xVal, yVal, zVal), Quaternion.identity);
        newBall.GetComponent<Rigidbody>().useGravity = true;
    }
}
