using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState: MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController; 

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController; 
        }

        //Add a force upwards to create jump
        //Make sure to check if our heroine is on the ground
        heroineController.heroineRB.AddForce(Vector3.up * _heroineController.JumpVelocity, ForceMode.Impulse); 
    }
}
