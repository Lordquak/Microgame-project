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
}
