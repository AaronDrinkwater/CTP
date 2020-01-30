using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform player;
    public Transform target;

    public GameObject tmp_target;

    public bool no_tmp_target;

    private float rotationFromCurvatureGain; //Proposed curvature gain based on user speed
    private float rotationFromRotationGain; //Proposed rotation gain based on head's yaw
    private float lastRotationApplied = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
