using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenInitialLaunch : MonoBehaviour
{
  private void Awake()
  {
    transform.LookAt(new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50)));
  }
}
