using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeroineState
{
    //Permits state classes to access public properties of
    //  our main controllers
    void Handle(HeroineController controller);
}