using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationFadeeOut : MonoBehaviour
{
    public Animator animator;

    public void fadeOut()
    {
        animator.Play("OUtEnd");
    }
    public void fadeMenu()
    {
        animator.Play("menuAway");
    }




}
