using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientState: MonoBehaviour
{
    private HeroineController _heroineController;

    void Start()
    {
        _heroineController = (HeroineController)FindObjectOfType(typeof(HeroineController));   
    }

    void Update()
    {
        //Check to see if we are jumping
        //Check here to see if our player is grounded
        //  so that we don't keep jumping 
        if (Input.GetKeyDown(KeyCode.Space) && _heroineController.isGrounded)
        {
            Debug.Log("We are jumping!");
            _heroineController.HeroineJump(); 
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("We are diving!");
            _heroineController.HeroineDive();
        }

        //Check to see if we are diving
        //NOTE that we need to state that when we unpress
        //  left control we return to standing
        
        if(Input.GetKeyDown(KeyCode.LeftControl) && _heroineController.isGrounded)
        {
            Debug.Log("We are ducking!");
            _heroineController.HeroineDuck(); 
        }

        //Check and return to standing 
        //NOTE we are going to have to do this when 
        //  we are walking
        if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            Debug.Log("Return to standing");
            _heroineController.HeroineStand();
        }

        //Check to see if we are walking 
        //  Include left and right controls
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("We are walking!");
            _heroineController.HeroineWalk();
        }

        //Check to see if we are pressing down to sneak
        if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("We are sneaking");
            _heroineController.HeroineSneak(); 
        }
       if(Input.GetKeyUp(KeyCode.C))
        {
            _heroineController.HeroineWalk();
            _heroineController.HeroineStand(); 
        }

       //Are we pressing down the key to shrink
       if(Input.GetKeyDown(KeyCode.T))
        {
            _heroineController.HeroineShrink();
            Debug.Log("Shrink");
        }
       if(Input.GetKeyUp(KeyCode.T))
        {
            _heroineController.HeroineStand();
        }
    }
}
