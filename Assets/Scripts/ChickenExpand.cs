using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenExpand : MonoBehaviour
{
  public Transform chicken;
  private void Start()
  {
    chicken = this.gameObject.transform;
  }
  
  private void OnTriggerEnter(Collider other)
  {
    if (other.transform.tag == "Pin")
    {
      chicken.transform.localScale = new Vector3(9, 9, 9);
      Destroy(chicken.gameObject, 3f);
    }
  }
}
