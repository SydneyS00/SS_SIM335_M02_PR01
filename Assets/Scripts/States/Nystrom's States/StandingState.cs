using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController; 

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController; 
        }

        //Can this have no speed since this is our starting state
        //  and we are still??

        _heroineController.CurrentSpeed = _heroineController.maxSpeed;

        _heroineController.transform.localScale = new Vector3(1, 1, 1);

    }
}
