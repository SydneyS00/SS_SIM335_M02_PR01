using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController; 

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController;
        }

        //We want to be able to either walk left or right 
        //Use our designated walking speed instead of max speed
        _heroineController.CurrentSpeed = _heroineController.walkSpeed;

        //Now we want to establish controls for walking either left or right
        if (Input.GetKey(KeyCode.A))
        {
            _heroineController.heroineRB.transform.Translate(-5 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            _heroineController.heroineRB.transform.Translate(5 * Time.deltaTime, 0, 0);
        }
        
    }
}
