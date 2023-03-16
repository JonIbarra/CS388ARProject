using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpheres : MonoBehaviour
{
    public GameObject prefab;
    public Transform imageTransform;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Instantiate(prefab, new Vector3(imageTransform.position.x, imageTransform.position.y, imageTransform.position.z + 7.5f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
