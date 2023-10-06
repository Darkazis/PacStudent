using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{

    public AudioSource StartMusic;
    public AudioSource NormalGhosts;
    bool NormalStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        StartMusic.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!StartMusic.isPlaying && !NormalStarted)
        {
            NormalGhosts.Play(); 
            NormalStarted = true;
        }
    
        
    }
}
