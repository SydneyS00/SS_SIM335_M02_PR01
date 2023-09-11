using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeroineState
{
    //We use these to change in between states 
    public void Entry(HeroineController heroine);
    public void Exit(HeroineController heroine);
    public void Update(HeroineController heroine);
}

