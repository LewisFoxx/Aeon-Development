using UnityEngine;

// Press the space key in Play Mode to switch to the Bounce state.

public class Animations : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift));
        {
            anim.Play("Run");
        }
    }
}