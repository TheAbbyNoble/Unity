using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalFetch : MonoBehaviour
{

  public GameObject journalUI;
  public static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.J))
      {
        if(GameIsPaused)
        {
          Resume();
        }
          else
        {
          Pause();
        }
      }
    }

    public void Resume()
    {
      journalUI.SetActive(false);
      Time.timeScale = 1f;
      GameIsPaused = false;
      Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
      journalUI.SetActive(true);
      Time.timeScale = 0f;
      GameIsPaused = true;
      Cursor.lockState = CursorLockMode.None;
    }





}
