using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public static GameManager ins;
    public IVCanvas ivCanvas;
    public InventotyDisplay invDisplay;

  //  [HideInInspector]
    public Node currentNode;
    public Item itemHeld;

    public CameraRing rig;

    void  Awake(){
      ins = this;
      ivCanvas.gameObject.SetActive(false);
    }

    void Update(){

      if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<Prop>() != null) {
        if (ivCanvas.gameObject.activeInHierarchy) {
            ivCanvas.Close();
            return;
        }
        currentNode.GetComponent<Prop>().loc.Arrive();
      }

    }


}
