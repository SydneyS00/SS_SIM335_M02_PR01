using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState: MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;

    private Vector3 newScale = new Vector3(1, 0.5f, 1);

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController; 
        }

        _heroineController.CurrentSpeed = _heroineController.maxSpeed;

        //smoosh our character
        _heroineController.transform.localScale = newScale;


    }
}
