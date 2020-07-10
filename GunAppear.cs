using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAppear : MonoBehaviour
{
  public GameObject gunEnable;

  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player"))
    {
      gunEnable.SetActive(true);
    }
  }

}
