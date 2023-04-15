using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float hangTime;
    bool dropped = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        hangTime = Random.Range(1f, 10f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > hangTime && !dropped) {
            rb.useGravity = true;
        }
    }
}
