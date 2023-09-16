using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroineStateContext
{
    //Get the state that we are in and set it
    public IHeroineState CurrentState
    {
        get;
        set;
    }

    private readonly HeroineController _heroineController;

    public HeroineStateContext(HeroineController heroineController)
    {
        _heroineController = heroineController;
    }

    public void Transition()
    {
        CurrentState.Handle(_heroineController);
    }

    public void Transition(IHeroineState state)
    {
        CurrentState = state;
        CurrentState.Handle(_heroineController);
    }

}