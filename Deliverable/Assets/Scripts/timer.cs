using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    private float currentTime;
    public float startingTime = 30f;
    public TextMeshProUGUI countdown;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdown.text = "Time: " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            // Your Code Here
        }
    }
}