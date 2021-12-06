using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateChickenVelocity : MonoBehaviour
{
  public Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
    _rb.AddForce(new Vector3(250, 250));
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
