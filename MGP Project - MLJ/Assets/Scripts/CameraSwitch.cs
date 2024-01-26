using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float timer;
    public float gtime;
    public float mtime;

    public ItemCollector counter;

    void Update()
    {
        if (0f<timer)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);

            timer -= Time.deltaTime;


        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && counter.pills>0)
            {
                timer = gtime;
                gtime -= 0.5f;

                if (gtime < mtime)
                {
                    gtime = mtime;
                }
            }
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

       
    }
}