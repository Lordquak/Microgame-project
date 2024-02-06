using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    float playerpositions;
    public float speed = 0.5f;

    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerpositions = player.transform.position.y;
    }


    void Update()
    {
        float offset = (player.transform.position.y - playerpositions) * speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, offset));
    }
}
