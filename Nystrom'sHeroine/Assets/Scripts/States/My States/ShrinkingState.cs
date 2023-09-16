using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;

    private Vector3 shrinkScale = new Vector3(0.5f, 0.5f, 0.5f);

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController;
        }

        _heroineController.CurrentSpeed = _heroineController.maxSpeed;

        //Add in our shrinking scale
        _heroineController.transform.localScale = shrinkScale; 
    }
}