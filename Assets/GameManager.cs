using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int cookies;
    public static int multiplier;

    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        cookies = PlayerPrefs.GetInt("cookies", 0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
