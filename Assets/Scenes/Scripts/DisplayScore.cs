using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    ScoreKeeper sk;
    
    void Awake() {
        sk = FindObjectOfType<ScoreKeeper>();
    }

    void Update()
    {
        if (sk != null) {
            
        }
    }
}
