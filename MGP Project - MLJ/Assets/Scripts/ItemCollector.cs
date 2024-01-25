using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int pills = 0;

    [SerializeField] Text pillsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pill"))
        {
            Destroy(other.gameObject);
            pills++;
            pillsText.text = "Pills: " + pills;
        }
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("Teleport");

        if (Input.GetKey(KeyCode.E) && pills > 0)
        {

        }
    }
}
