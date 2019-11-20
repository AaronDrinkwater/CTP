using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrLookWalk : MonoBehaviour
{

    public Transform vr_Camera;

    public float toggle_angle = 30.0f;
    public float speed = 3.0f;


    public bool move_Foward;
    private CharacterController cc;

    void Start()
    {
        cc = GetComponentInChildren<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vr_Camera.eulerAngles.x >= toggle_angle && vr_Camera.eulerAngles.x < 90.0)
        {
            move_Foward = true;

        }
        else
        {
            move_Foward = false;
        }

        if(move_Foward)
        {
           Vector3 forward = vr_Camera.TransformDirection(Vector3.forward);
           cc.SimpleMove(forward * speed);
             
        }
    }
}
