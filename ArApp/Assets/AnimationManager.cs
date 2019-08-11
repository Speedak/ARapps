using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animation  _animation;
    private bool  _IsInAction = false;
    // Start is called before the first frame update
     void Start(){
      _animation = GetComponent<Animation>();  
     }
     
     public void Walk()
     {
        if(_IsInAction==true)
         return;

     _IsInAction = true;
     _animation.Play("Spider_Armature|run_ani_vor");
     Invoke("ResetAnimation", 0.14f);
     }

    
    //Spider_Armature|normal
    //public void Jump()
    //{
    //if(_IsInAction==true)
    // return;
    //
    // _IsInAction = true;
    //_animation.play("Spider_Armature|Jump");
    //Invoke("ResetAnimation", 1.4f);
    //}


    private void ResetAnimation()
    {
    _animation.Play("idle");
    _IsInAction = false;
    } 


}