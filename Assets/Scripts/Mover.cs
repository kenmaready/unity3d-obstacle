using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    
    ScoreKeeper sk;
    float moveSpeed = 2f;
    bool inCollision = false;

    void Awake() {
        sk = FindObjectOfType<ScoreKeeper>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        float zVal = -Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float xVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        // "Horizontal" moves up and doan and "Vertical" side to side
        // because game screen is rotated 90 degrees.
        transform.Translate(xVal, 0, zVal);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Ground" && !inCollision) {
            inCollision = true;
            sk.ChangeScore(10);

            StartCoroutine(TurnCollisionFlagOff());
        }
        
    }

    private IEnumerator TurnCollisionFlagOff() {
        yield return new WaitForSeconds(0.1f);

        inCollision = false;
    }
}
