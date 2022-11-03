using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramStop : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
