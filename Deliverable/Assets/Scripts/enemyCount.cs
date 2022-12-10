using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enemyCount : MonoBehaviour
{
    private float currentScore;
    public float startingScore = 0;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = startingScore;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Defeated: " + currentScore + " / 5";
    }
}
