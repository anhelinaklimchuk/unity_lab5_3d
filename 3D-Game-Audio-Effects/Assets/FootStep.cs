using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootStep : MonoBehaviour
{
    public AudioClip[] myClip1;
    public AudioClip[] myClip2;

    private void OnTriggerStay(Collider myColl)
    {
        if(myColl.tag == ("Wood"))
        {
            GetComponent<FirstPersonController>().m_FootstepSounds = myClip1;
        }
    }

    private void OnTriggerExit()
    {
        GetComponent<FirstPersonController>().m_FootstepSounds = myClip2; 
    }
    
        
    
}
