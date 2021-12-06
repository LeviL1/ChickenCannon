using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDuplicate : MonoBehaviour
{
  public Transform spawnPoint1;
  public Transform spawnPoint2;
  public Transform spawnpoint3;
  public GameObject chicken;
  private void Start()
  {
    
    
    StartCoroutine(spawnOtherChickensRoutine());
    
  }
  IEnumerator spawnOtherChickensRoutine() 
  {
    
    yield return new WaitForSeconds(1.9f);
    spawnChickens();
    
  }
  public void spawnChickens() 
  {
    Instantiate(chicken, spawnPoint1);
    Instantiate(chicken, spawnPoint2);
    Instantiate(chicken, spawnpoint3);
    StopCoroutine(spawnOtherChickensRoutine());
  }
}
