using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSpawnController : MonoBehaviour
{
    public GameObject mTargetObject;
    GameObject mBasket;
    public UnityEngine.UI.Text mText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBasket()
    {
        mText.text = "Found Target";
    }

    public void DestroyBasket()
    {
        mText.text = "Target Lost";
    }


}
