using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Circle : MonoBehaviour
{
    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WierdRotation();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    protected abstract void WierdRotation();
}
