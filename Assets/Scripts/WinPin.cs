using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPin : MonoBehaviour
{
  public PinCheck pins;
  // Start is called before the first frame update
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player") 
    {
      pins.FinishedLevel.enabled = true;
      pins.chickencount.text = $"All pins knocked it took {pins.cannonManager.numberOfChickens} chickens";
    }
  }
}
