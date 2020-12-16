using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelLoader : MonoBehaviour
{

  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player"))
    {
      SkipLevel();
    }
  }

public void SkipLevel()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }


}
