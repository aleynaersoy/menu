using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
  public void playgame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Quitgame()
    {
        Debug.Log("oyundan ��k�ld�:");
        Application.Quit();
    }
    public void ReturntoMainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
