using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        Debug.Log("Sono un Awake");
    }
    void Start()
    {
        Debug.Log("Sono uno start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Sono un update");
    }

    void LateUpdate()
    {
        //Debug.Log("Sono un late update");
    }

    void FixedUpdate()
    {
        //Debug.Log("Sono un fixed update");
        //Debug.Log(Time.time);
    }
}
