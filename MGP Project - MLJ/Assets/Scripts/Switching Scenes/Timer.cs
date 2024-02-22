using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    public float min = 5.0f;

    private void Start()
    {
        timer -= min;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("New Apocalypse");
        }
    }
}
