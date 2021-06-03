using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiInteraction : MonoBehaviour
{
    [SerializeField] private GameObject mMessagePanel;
    [SerializeField] private GameObject mMessageText;




    private Text txtMessage;

    // Start is called before the first frame update
    void Start()
    {
        txtMessage = mMessageText.GetComponent<Text>();
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0f, 0f);
    }



    public void Activate(string message)
    {
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 1f, 0f);
        txtMessage.text = message;
    }


    public void Deactivate()
    {
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0f, 0f);

    }
}






