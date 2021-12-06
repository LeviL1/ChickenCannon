using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCont : MonoBehaviour
{
  public Transform platform;
  public float zMin = -1;
  public float zMax = 1;
  private void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.RightArrow) && platform.position.z >zMin)
    {
      float z = platform.position.z;
      z -= 0.1f;
      platform.position = new Vector3(platform.position.x, platform.position.y, z);
    }
    if (Input.GetKey(KeyCode.LeftArrow) && platform.position.z < zMax)
    {
      float z = platform.position.z;
      z += 0.1f;
      platform.position = new Vector3(platform.position.x, platform.position.y, z);
    }
  }

}
