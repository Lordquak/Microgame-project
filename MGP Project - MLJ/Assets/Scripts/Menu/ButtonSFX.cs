using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFx;
    public AudioClip clickFX;

    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFx);
    }
    public void ClickSound()
    {
        myFX.PlayOneShot(clickFX);
    }
}
