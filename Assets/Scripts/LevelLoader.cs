using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
  public Image controlScreen;
  private void Start()
  {
    controlScreen.gameObject.SetActive(false);
  }
  public void ReloadCurrentLevel() 
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  public void LoadMainMenu() 
  {
    SceneManager.LoadScene("MainMenu");
  }
  public void loadLevel1() 
  {
    SceneManager.LoadScene("SampleScene");

  }
  public void loadLevel2() 
  {
    SceneManager.LoadScene("SampleScene 2");
  }
  public void showControls() 
  {
    controlScreen.gameObject.SetActive(true);
  }
  public void hideControls() 
  {
    controlScreen.gameObject.SetActive(false);
  }
}
