using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState: MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;
    
    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController;
        }

        //Do we need to set this at max speed? Why do I need to set 
        //  the speed if we are adding a downward force?
        _heroineController.CurrentSpeed = _heroineController.maxSpeed;

        //Actually move our heroine down
        _heroineController.heroineRB.AddForce(Vector3.down * _heroineController.DiveVelocity, ForceMode.Impulse);
        
    }
}
