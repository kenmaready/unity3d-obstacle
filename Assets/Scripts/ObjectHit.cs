using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    bool isHit = false;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player" && !isHit) {
            isHit = true;
            ChangeColor();
        }
    }

    private void ChangeColor() {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Debug.Log("Mesh Renderer: " + mr);
        Color originalColor = mr.material.color;
        Debug.Log("My color is: " + originalColor);
        mr.material.color = Color.green;

        Debug.Log("My color is now: " + mr.material.color);
        StartCoroutine(ChangeBack(mr, originalColor));
    }

    private IEnumerator ChangeBack(MeshRenderer mr, Color color) {
        yield return new WaitForSeconds(1);
        
        // Change back to original color & reset
        Debug.Log("Changing color back...");
        mr.material.color = color;
        isHit = false;
    }

}
