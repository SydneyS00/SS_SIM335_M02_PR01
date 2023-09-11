using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroineController : MonoBehaviour
{
    private IHeroineState curState = new Standing(); 
    public bool grounded = true; 

    void Transition(IHeroineState newState)
    {
        //exit function
        curState.Exit(this);
        //update our current state to be the new state
        curState = newState;
        //entry function
        curState.Entry(this);

    }

    void Update()
    {
        //Update our current state to the one we created
        curState.Update(this);       
    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true; 
    }



}
