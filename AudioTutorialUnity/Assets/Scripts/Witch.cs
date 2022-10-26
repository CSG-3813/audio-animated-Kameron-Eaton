/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified: 10/26/2022
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioSource;
    AudioClip clip;


    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        clip = audioSource.clip;

    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

public void playCackle()
    {
        audioSource.PlayOneShot(clip);
    }

}
