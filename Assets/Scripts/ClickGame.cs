using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickGame : MonoBehaviour{

    public List<ButtonCollorChange> buttons = new List<ButtonCollorChange>();
    public Button button;
    private int count = 0;

    void Start(){

    }

    void Update(){

      foreach (ButtonCollorChange btn in buttons) {
        if (!btn.isClieck()) {
          count++;
        }
      }
      if (count >= 7) {
        button.gameObject.SetActive(true);
      }else{
        button.gameObject.SetActive(false);
      }
      count= 0;

    }
}
