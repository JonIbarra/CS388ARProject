using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSpawnController : MonoBehaviour
{
    public GameObject mTargetObject;
    GameObject mBasket;
    public UnityEngine.UI.Text mText;
    int ts;
    
    // Start is called before the first frame update
    void Start()
    {
        ts = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBasket()
    {
        ts += 1;

        mText.text = "Found Target (" + ts + ")";
    }

    public void DestroyBasket()
    {
        mText.text = "Target Lost";
        ts = 0;
    }


}
