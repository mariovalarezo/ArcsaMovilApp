using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelController : MonoBehaviour, IAction
{
    [SerializeField] GameObject uiPanel;
    CursorController cc;
    [SerializeField] bool activeFirst;
   
    
    void Start()
    {
        cc = GameObject.FindObjectOfType<CursorController>();
        

        uiPanel.transform.localScale = new Vector3(0, 0, 0);

        if (activeFirst)
        {
            ActivateFirst();
        }
    }

   

    public void Activate()
    {

     

            LeanTween.scale(uiPanel, new Vector3(1, 1, 1), 0.5f);
            cc.ShowCursor();
      

    }
    public void ActivateFirst()
    {
        
       
            LeanTween.scale(uiPanel, new Vector3(1, 1, 1), 0f);
            cc.ShowCursor();
         

    }
    public void DesactivarTodo()
    {
        LeanTween.scale(uiPanel, new Vector3(0, 0, 0), 0.3f);
        cc.HideCursor();
        


    }
    public void Desctivar()
    {
        LeanTween.scale(uiPanel, new Vector3(0, 0, 0), 0.3f);      
       

    }


}
