using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standing: IHeroineState
{
    //This is our STANDING STATE
    //From standing we will be able to do the following: 
    //  JUMPING -> DIVING
    //  WALKING -> SPRINTING or SNEAKING
    //  DUCKING
    //Here are the controllers for the following 
    //  JUMPING: Pressing Space key 
    //  DIVING: Holding 'S' key
    //  DUCKING: Holding 'C' key
    //  WALKING: Pressing 'A' or 'D' keys
    //  SPRINTING: Holding Shift key
    //  SNEAKING: Holding Ctrl key


    //We don't really need to include the exit or entry function 
    //  since this is technically our starting state
    void IHeroineState.Exit(HeroineController heroine)
    {

    }

    void IHeroineState.Entry(HeroineController heroine)
    {

    }

    //This is where all the magic happens...I think
    void IHeroineState.Update(HeroineController heroine)
    {
        //We want to be able to do the following in this function
        //  JUMP
        //  DUCK
        //  WALK 
        //I am going to use If statements cause I am lazy

        //Check to see if we are clicking the button for jumping 
        
       
    }
}
