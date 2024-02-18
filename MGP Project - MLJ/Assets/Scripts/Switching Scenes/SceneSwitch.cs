using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public float timer;
    public float gtime;
    public float mtime;

    public ItemCollector counter;

    private void Start()
    {
        timer = 5f;
        
    }

    void Update()
    {
        if (0f < timer)
        {

            timer -= Time.deltaTime;
            

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && counter.pills > 0)
            {
                timer = 10f;
                timer = gtime;
                gtime -= 0.5f;
                counter.pills -= 1;

                if (gtime < mtime)
                {
                    gtime = mtime;
                }
            }
            SceneManager.LoadScene("New Apocalypse");
        }


    }
}
