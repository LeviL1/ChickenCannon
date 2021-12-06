using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PinCheck : MonoBehaviour
{
  public CannonManager cannonManager;
  public float PinsTipped = 0;
  public float NumberOfPins;
  public GameObject[] Pins;
  public Canvas FinishedLevel;
  public Text chickencount;
  private void Start()
  {
    FinishedLevel.enabled = false;
    Pins = GameObject.FindGameObjectsWithTag("Pin");
    NumberOfPins = Pins.Length;
  }
  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Pin")) 
    {
      PinsTipped += 1;
    }
  }
  private void Update()
  {
    if (PinsTipped == NumberOfPins) 
    {
      FinishedLevel.enabled = true;

      chickencount.text = $"All pins knocked it took {cannonManager.numberOfChickens} chickens";
    }
  }


}
