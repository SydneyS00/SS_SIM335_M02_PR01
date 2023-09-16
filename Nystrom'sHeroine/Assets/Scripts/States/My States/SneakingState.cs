using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;
    private Vector3 newScale = new Vector3(1, 0.5f, 1); 

    public void Handle(HeroineController heroineController)
    {
        if(!_heroineController)
        {
            _heroineController = heroineController; 
        }

        _heroineController.CurrentSpeed = _heroineController.sneakSpeed;
         
        //Squish it to look like it is sneaking
        _heroineController.transform.localScale = newScale;
        //Slowing it down
        _heroineController.heroineRB.transform.Translate(0.25f * Time.deltaTime, 0, 0);
        
    }

   
}
