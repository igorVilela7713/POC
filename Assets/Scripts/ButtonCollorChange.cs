using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCollorChange : MonoBehaviour{

  public Button button;
  private bool clicked = true;
  public bool required = false;

  void Start () {
    Button btn = button.GetComponent<Button>();
    btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick(){
      if (clicked) {
        TurnRed();
        clicked = false;
      }else{
        TurnWhite();
        clicked = true;
      }

	}

  public void TurnRed()
     {
         ColorBlock colors = button.colors;
         colors.normalColor = Color.green;
         colors.highlightedColor = new Color32(100, 255, 100, 255);
         button.GetComponent<Image>().color = Color.green;
         button.colors = colors;
     }

     public void TurnWhite()
     {
         ColorBlock colors = button.colors;
         colors.normalColor = Color.white;
         colors.highlightedColor = new Color32(225, 225, 225, 255);
         button.GetComponent<Image>().color = Color.white;
         button.colors = colors;
     }

     public bool isClieck(){
       return clicked;

     }
}
