using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroineController : MonoBehaviour
{
    //Variables 
    //Movement variables
    public float sneakSpeed;
    public float walkSpeed;
    public float sprintSpeed;
    public float maxSpeed = 10.0f; 

    //To change the position and size of our heroine
    public Rigidbody heroineRB;
    public float jumpVelocity = 15.0f;
    public float diveVelocity = 15.0f;

    public bool isGrounded = true;

    public GameObject ourHeroine;

    

    public float CurrentSpeed { get; set; }
    public float JumpVelocity { get { return jumpVelocity; } }
    public float DiveVelocity { get { return jumpVelocity; } }




    public IHeroineState _standingState, _jumpingState, _divingState, _duckingState, _walkingState, _sprintingState, _sneakingState;
    private HeroineStateContext _heroineStateContext;

    private void Start()
    {
        _heroineStateContext = new HeroineStateContext(this);
        
        //Nystrom's states
        _standingState = gameObject.AddComponent<StandingState>();
        _jumpingState = gameObject.AddComponent<JumpingState>();
        _divingState = gameObject.AddComponent<DivingState>();
        _duckingState = gameObject.AddComponent<DuckingState>();

        //My own states
        _walkingState = gameObject.AddComponent<WalkingState>();
        //_sneakingState = gameObject.AddComponent<SneakingState>();
       // _sprintingState = gameObject.AddComponent<SprintingState>();

        _heroineStateContext.Transition(_standingState);
    }

    //STAND STATE 
    public void HeroineStand()
    {
        _heroineStateContext.Transition(_standingState);
        Debug.Log("Stand");
    }
    //JUMP STATE
    public void HeroineJump()
    {
        _heroineStateContext.Transition(_jumpingState);
        //To check if this function works 
        Debug.Log("Jump");
    }

    //DIVE STATE
    public void HeroineDive()
    {
        _heroineStateContext.Transition(_divingState);
        //To check if this function works
        Debug.Log("Dive");
    }

    //DUCK STATE
    public void HeroineDuck()
    {
        _heroineStateContext.Transition(_duckingState);
        Debug.Log("Duck");
    }

    //WALK STATE
    public void HeroineWalk()
    {
        _heroineStateContext.Transition(_walkingState);
        Debug.Log("Walk");
    }

}
