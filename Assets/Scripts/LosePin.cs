using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePin : MonoBehaviour
{
  public LevelLoader level;
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      level.ReloadCurrentLevel();
    }
  }

  
}
