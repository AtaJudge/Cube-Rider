using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public bool gameHasEnded = false;
  public GameObject completeLevelUI;

  private bool tempCanDeath;

  private bool canWin = true;

  private void Update()
  {
    tempCanDeath = FindObjectOfType<EndTrigger>().canDeath;
  }

  public void CompleteLevel()
  {
    if (canWin)
    {
      print("Level Won!");
      completeLevelUI.SetActive(true);
      FindObjectOfType<EndTrigger>().canDeath = false;
    }
  }
  
  public void GameOver()
  {
    if (tempCanDeath)
    {
      if (gameHasEnded == false)
      {
        gameHasEnded = true;
        print("Game Over");
        Invoke(nameof(Restart), 2f);
        canWin = false;
      }
    }
  }

  void Restart ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
