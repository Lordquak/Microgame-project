using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int pills = 0;

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

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pillsText.text = "Pills: " + pills;
        }
    }
}
