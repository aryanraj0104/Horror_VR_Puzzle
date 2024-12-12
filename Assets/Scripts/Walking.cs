using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform VRPlayer;
    public float lookdownangle = 25.0f;
    public float speed = 3.0f;
    private bool moveForward;
    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VRPlayer.eulerAngles.x >= lookdownangle && VRPlayer.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward == true)
        {
            Vector3 forward = VRPlayer.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward*speed);
        }
    }
}
