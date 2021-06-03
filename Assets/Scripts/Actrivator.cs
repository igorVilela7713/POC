using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Actrivator : MonoBehaviour{

    public GameObject tongue;

  void Start ()
  {
      InvokeRepeating("TongueOut", 3f, 1f);
  }

  void TongueOut ()
  {
      tongue.SetActive(true);
      Invoke("TongueIn", 0.5f);
  }

  void TongueIn ()
  {
      tongue.SetActive(false);
  }
}
