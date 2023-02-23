using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject Character;

    private void ExecuteTrigger(string trigger)
    {
        var animator = Character.GetComponent<Animator>();
        if(animator != null)
        {
            animator.SetTrigger(trigger);
        }
    }

    public void PlayIdleAnim()
    {
        ExecuteTrigger("TrIdle");
    }

    public void PlayWalkRight()
    {
        ExecuteTrigger("TrWalkRight");
    }

    public void PlayWalkLeft()
    {
        ExecuteTrigger("TrWalkLeft");
    }
}
