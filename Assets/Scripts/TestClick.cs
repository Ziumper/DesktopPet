using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{
    public GameObject SomeRandomGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TestingClicking()
    {
        SomeRandomGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
