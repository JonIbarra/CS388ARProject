using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpheres : MonoBehaviour
{
    public GameObject prefab;
    Camera mCamera;

    // Start is called before the first frame update
    void Start()
    {
        mCamera = GetComponent<Camera>();
        Vector3 offset = mCamera.transform.forward * 5;
        
        //prefab = Instantiate(prefab, new Vector3(transform.position.x + offset.x, transform.position.y + offset.y, transform.position.z + offset.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
