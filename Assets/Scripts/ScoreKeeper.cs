using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{

    int score = 0;
    [SerializeField] TextMeshProUGUI display;

    public int GetScore() {
        return score;
    }

    public void ChangeScore(int val) {
        score += val;

        if (display != null) {
            display.text = score.ToString().PadLeft(4,'0');
        }
    }

}
