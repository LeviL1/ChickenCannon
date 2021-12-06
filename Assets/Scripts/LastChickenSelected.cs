using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LastChickenSelected : MonoBehaviour
{
  public Text smallChicken;
  public Text mediumChicken;
  public Text bigChicken;
  public Text lastTextSelected;
  private void Start()
  {
    smallChicken.enabled = false;
    mediumChicken.enabled = false;
    bigChicken.enabled = false;
  }

  // Update is called once per frame
  void Update()
    {
    if (Input.GetKeyDown(KeyCode.Alpha1)) 
    {
      lastTextSelected.enabled = false;
      lastTextSelected = smallChicken;
      lastTextSelected.enabled = true;
    }
    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      lastTextSelected.enabled = false;
      lastTextSelected = mediumChicken;
      lastTextSelected.enabled = true;
    }
    if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      lastTextSelected.enabled = false;
      lastTextSelected = bigChicken;
      lastTextSelected.enabled = true;
    }


  }
}
