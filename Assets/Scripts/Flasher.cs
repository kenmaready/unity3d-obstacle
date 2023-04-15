using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flasher : MonoBehaviour
{

    bool isFlashing = false;


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" && !isFlashing) {
            Debug.Log("Player is here!");
            isFlashing = true;
            StartCoroutine(Flash());
        }
    }

    IEnumerator Flash() {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Color startColor = mr.material.color;
        bool isNewColor = false;

        for (int i = 0; i < 12; i++) {
            if (isNewColor) {
                Debug.Log("Flashing back to White...");
                mr.material.color = startColor;
                isNewColor = false;
            } else {
                Debug.Log("Flashing to Green...");
                mr.material.color = Color.green;
                isNewColor = true;
            }

            yield return new WaitForSeconds(0.2f);
        }

    }
}
