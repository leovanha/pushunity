using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audiosource : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip nhacnen, jump, die, bandan,trungdan;
    public static audiosource _audiosource;
    public GameObject music;
 
    void Start()
    {
        audio.GetComponent<audiosource>();
        _nhacnen();
    }

    public void _trungdan()
    {       
            audio.PlayOneShot(trungdan);        
    }
    public void _die()
    {         
            audio.PlayOneShot(die);
    }
    public void _bandan()
    {
        audio.PlayOneShot(bandan);
    }
    public void _nhacnen()
    {
        audio.PlayOneShot(nhacnen);
    }
    public void _tatnhacnen()
    {       
        Destroy(music);
    }
}
