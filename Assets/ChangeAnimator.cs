﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
   public void getAnimatorDefeate(){
       this.GetComponent<Animator>().Play("Defeated");
   }
   public void getAnimatorBrekedance(){
       this.GetComponent<Animator>().Play("Breakdance 1990");
   }
}
