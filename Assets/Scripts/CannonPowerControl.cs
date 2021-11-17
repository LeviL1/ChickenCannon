using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPowerControl : MonoBehaviour
{
  public float powerSliderAmount = 0f;
  
  bool countingUp = true;
  private void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.C))
    {
      StartCoroutine(CountingRoutine());
    }
    
  }
  IEnumerator CountingRoutine() 
  {
    if (countingUp)
    {

      powerSliderAmount += 1;
    }
    if (!countingUp)
    {
      powerSliderAmount -= 1;
    }
    if (powerSliderAmount == 100)
    {
      countingUp = false;


    }
    if (powerSliderAmount == 0)
    {
      countingUp = true;
    }
    yield return new WaitForSeconds(2f);
  }
}
