using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startPos;
    Vector2 endPos;
    Vector2 dir;

    float touchStartTime;
    float touchEndTime;
    float timeInterval;

    float throwForceInXandY = 1f;
    float throwForceInZ = 50f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchStartTime = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchEndTime = Time.time;
            timeInterval = touchEndTime - touchStartTime;

            endPos = Input.GetTouch(0).position;

            dir = startPos - endPos;

            rb.useGravity = true;
            rb.isKinematic = false;
            rb.AddForce(-dir.x * throwForceInXandY, -dir.y * throwForceInXandY, throwForceInZ / timeInterval);

            Destroy(gameObject, 3f);

        }
    }
}
