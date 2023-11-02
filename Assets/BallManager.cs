using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class BallManager : MonoBehaviour
{
    public float speed = 1.0f; // Speed of the ball
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.isMine) {
            if (transform.position.y < -5)
            {
                transform.position = new Vector3(transform.position.x, 10, transform.position.z);
            }

            Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            if (thumbstickInput != Vector2.zero)
            {
                Vector3 moveDirection = new Vector3(thumbstickInput.x, 0, thumbstickInput.y);
                transform.position += moveDirection * speed * Time.deltaTime;
        }
        }
    }
}
