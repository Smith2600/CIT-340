using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited Game!");
    }
}