using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MoveSpeed;
    public Animator Animator;

    public float Framerate;
    public float FallSpeed;

    private bool FacingDiagonal;

    public Vector3 CameraForward;
    public Vector3 CameraRight;
    public Vector3 TestMove;
    public Vector3 Move;

    public GameObject CameraController;
    public GameObject Camera;

    public Rigidbody PlayerRigid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!StaticScrpt.Lockmovement)
        {
            Movement();
            CharacterRotation();
        }
    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (x != 0 || z !=0)
        {
            //Animator.SetBool("Walking", true);
            CameraForward = CameraController.transform.right;
            CameraRight = CameraController.transform.forward;
            TestMove = new Vector3(x, 0, z);
            Move = (CameraController.transform.right * x + CameraController.transform.forward * z).normalized;
            //Move = new Vector3(Move.x, PlayerRigid.velocity.y, Move.z);
            PlayerRigid.velocity = Move * Time.deltaTime * MoveSpeed * Framerate;
        }
        else
        {
            PlayerRigid.velocity = new Vector3(0, 0, 0);
        }
    }

    public void CharacterRotation()
    {
        // Diagonal
        if (Input.GetButton("Vertical") && Input.GetButton("Horizontal")) // check to see if two directional buttons are being pressed
        {
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0) // Up and right??
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 45, 0));
                FacingDiagonal = true;
            }
            else if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0) // Down and right?
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 135, 0));
                FacingDiagonal = true;
            }
            else if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0) // Down and Left
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 225, 0));
                FacingDiagonal = true;
            }
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0) // Up and Left
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 315, 0));
                FacingDiagonal = true;
            }
        }
        else if ((Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") == 0) || (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") != 0))
        {
            FacingDiagonal = false;
            if (Input.GetAxis("Horizontal") < 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            }

            // Forward & Backwards
            if (Input.GetAxis("Vertical") > 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
        }
    }

}
