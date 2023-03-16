using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startPos;
    Vector2 endPos;

    float touchStartTime;
    float touchEndTime;
    float timeInterval;

    public float throwForceForward;
    public float throwForceUp;

    Rigidbody rb;

    public Transform mCamTransform;
    public GameObject mTarget;
    bool physics_active;
    bool active;

    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ResetBall();
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active)
        {
            if (!physics_active)
            {
                dir = mCamTransform.forward * throwForceForward + mCamTransform.up * throwForceUp;

                rb.useGravity = true;
                rb.isKinematic = false;
                rb.velocity = dir;
                Physics.gravity = mTarget.transform.up * (-1000);

                //transform.position = dir;

                physics_active = true;
                Invoke("ResetBall", 5);
            }
            else
            {
                ResetBall();
            }
        }
        if (!physics_active)
        {
            Vector3 offset = mCamTransform.forward * 250;
            Debug.Log("Location: " + offset);

            transform.position = new Vector3(mCamTransform.position.x + offset.x, mCamTransform.position.y + offset.y, mCamTransform.position.z + offset.z);
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchEndTime = Time.time;
            timeInterval = touchEndTime - touchStartTime;

            endPos = Input.GetTouch(0).position;

        }
    }

    void ResetBall()
    {
        if (physics_active)
        {
            physics_active = false;
            rb.useGravity = false;
            rb.isKinematic = false;
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    public void ThrowActivate()
    {
        active = true;
    }
    public void ThrowDeactivate()
    {
        active = false;
    }
}
