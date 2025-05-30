using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource sfx;
    public AudioSource epl;
    public AudioClip background;
    public AudioClip bullet;
    public AudioClip explosion;

    void Start()
    {
        sound.clip = background;
        sound.Play();
    }

    public void playSFX(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }

    public void playExpl(Audio clip)
    {
        epl.PlayOneShot(clip);
    }
}
