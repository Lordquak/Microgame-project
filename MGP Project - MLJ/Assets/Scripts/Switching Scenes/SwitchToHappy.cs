using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToHappy : MonoBehaviour
{
    public ItemCollector counter;

    public float timer;
    public float gtime;
    public float mtime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && counter.pills > 0)
        {
            SceneManager.LoadScene("New Post");
        }
    }
}
