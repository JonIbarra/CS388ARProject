using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningController : MonoBehaviour
{
    int mPoints;
    public UnityEngine.UI.Text mText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            mPoints += 1;
            mText.text = "Points: " + mPoints;
        }
    }
}
