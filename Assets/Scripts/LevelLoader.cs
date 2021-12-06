using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{

  public void ReloadCurrentLevel() 
  {
    SceneManager.LoadScene(1);
  }
  public void LoadMainMenu() 
  {
    SceneManager.LoadScene("MainMenu");
  }
}
