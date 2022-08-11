using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Volume : MonoBehaviour
{
    [SerializeField] private AudioMixer soundControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume(float volume)
    {
        //(volume of mixer, volume of function)
        soundControl.SetFloat("volumeMixer", volume);
    }
}
