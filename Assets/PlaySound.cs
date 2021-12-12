using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public void PlaySpecialSound(AudioClip sound)
    {
        Game.instance.audioSource.PlayOneShot(sound);
    }
}
