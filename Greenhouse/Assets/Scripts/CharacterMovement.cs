using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public bool LockMovement;
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
        if (!LockMovement)
        {
            Movement();
        }
    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (x != 0 || z !=0)
        {
            Animator.SetBool("Walking", true);
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
   

    
}
