using UnityEngine;

// Press the space key in Play Mode to switch to the Bounce state.

public class Animations : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    void Update() {
        RunDup();
        //IdleWlk():

    }

    void RunDup()
    {
        anim.SetBool("Run", Input.GetButton("Fire3"));
    }
        
}