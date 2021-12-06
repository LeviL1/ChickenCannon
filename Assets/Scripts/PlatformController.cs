using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
  public Transform platform;
  
  private void Update()
  {
    if (Input.GetKey(KeyCode.RightArrow) && platform.position.z > -1) 
    {
      float z = platform.position.z;
      z -= 0.1f;
      platform.position = new Vector3(platform.position.x, platform.position.y, z);
    }
    if (Input.GetKey(KeyCode.LeftArrow) && platform.position.z != 1) 
    {
      float z = platform.position.z;
      z += 0.1f;
      platform.position = new Vector3(platform.position.x, platform.position.y, z);
    }
  }
}
