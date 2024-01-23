using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
