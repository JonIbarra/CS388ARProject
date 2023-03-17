using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningController : MonoBehaviour
{
    int mPoints;
    public UnityEngine.UI.Text mText;
    bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Sphere" && active)
        {
            mPoints += 1;
            mText.text = "Points: " + mPoints;
            active = false;
        }
    }

    public void Reset()
    {
        active = true;
    }
}
