using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    public GameObject marker;
    public Transform player;
    public float ray_length = 50.0f;

    void Start()
    {
        OVRTouchpad.Create();
        OVRTouchpad.AddListener(LocalTouchEventCallback);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, ray_length))
        {
            if (hit.collider.tag == "Ground")
            {
                if (!marker.activeSelf)
                {
                    marker.SetActive(true);
                }
            }

            marker.transform.position = hit.point;
        }
        else
        {
            marker.SetActive(false);
        }

    }
       

    //void TouchpadHandler(object sender, System.EventArgs e)
    //{
    //    OVRTouchpad.TouchArgs args = (OVRTouchpad.TouchArgs)e;

    //}

    private void LocalTouchEventCallback(OVRTouchpad.TouchEvent button)
    {
        switch (button)
        {
            case (OVRTouchpad.TouchEvent.SingleTap):
                
                if(marker.activeSelf)
                {
                    Vector3 markerPosition = marker.transform.position;
                    player.position = new Vector3(markerPosition.x, player.position.y,
                        markerPosition.z);
                }

                break;
            case (OVRTouchpad.TouchEvent.DoubleTap):
                // Do some stuff
                break;

        }
    }
}
 