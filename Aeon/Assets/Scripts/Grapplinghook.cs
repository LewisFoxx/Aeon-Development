using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Grapplinghook : MonoBehaviour 
{

    public Camera cam;
    public RaycastHit hit;

    public LayerMask cullingmask;
    public int Maxdistance;

    public bool IsFlying;
    public Vector3 loc;

    public float speed = 10;
    public Transform hand;

    public FirstPersonController FPC;
    public LineRenderer LR;

	// Use this for initialization
	void Start () 
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Q))
            Findspot();

        if (IsFlying)
            Flying();

        if(Input.GetKey(KeyCode.Space) && IsFlying)
        {
            IsFlying = false;
            FPC.CanMove = true;
            LR.enabled = false;
        }
	}

    public void Findspot()
    {
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, Maxdistance, cullingmask))
        { 
            IsFlying = true;
            loc = hit.point;
            FPC.CanMove = false;
            LR.enabled = true;
            LR.SetPosition(1, loc);
        }
    }

    public void Flying()
    {
        transform.position = Vector3.Lerp(transform.position, loc, speed * Time.deltaTime / Vector3.Distance(transform.position, loc));
        LR.SetPosition(0, hand.position);

        if(Vector3.Distance(transform.position, loc) < 0.5f)
        {
            IsFlying = false;
            FPC.CanMove = true;
            LR.enabled = false;
        }
    }
}
