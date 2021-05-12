using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMe : MonoBehaviour
{
    [HideInInspector] float timer;
    private bool notYetPlayed = true;

    private void Update() 
    {
        timer += Time.deltaTime;
    }
    public void PlayAudio(float dur)
    {   
        if (timer>=.2 || notYetPlayed)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        timer = 0;
        notYetPlayed = false;
    }
}
