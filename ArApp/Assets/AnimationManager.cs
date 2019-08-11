using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animation _animation;
    private bool _IsInAction = false;
    // Start is called before the first frame update
    void Start(){
     _animation = GetComponent<Animation>();  
    }
     
    public void Walk()
    {
    	if(_IsInAction==true)
    	return;

    	_IsInAction = true;
    	_animation.play("Spider_Armature|run_ani_vor");
    	Invoke("ResetAnimation", 0.14f);
    }

    public void Jump()
    {
    	if(_IsInAction==true)
    	return;

    	_IsInAction = true;
    	_animation.play("Spider_Armature|Jump");
    	Invoke("ResetAnimation", 1.4f);
    }


    private void ResetAnimation()
    {
    	_animation.play("idle");
    	_IsInAction == false;
    } 


}