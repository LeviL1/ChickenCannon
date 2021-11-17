using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
  public float powerSliderAmount = 0f;
  public float confirmsPowerAmt;
  private void FixedUpdate()
  {
    if (powerSliderAmount == 0 && powerSliderAmount != 100) 
    {
      powerSliderAmount += 1;
    }
    if (powerSliderAmount == 100)
    {
      powerSliderAmount -= 1;
    }
  }
}
