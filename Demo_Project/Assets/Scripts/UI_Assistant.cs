using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text uiText;
    private string messages;

    private void Awake()
    {
        uiText = transform.Find("dialogBox").Find("messageText").GetComponent<Text>();
    }
    void Start()
    {
        //messageText.text = "Hello World!";
        textWriter.AddWriter(uiText, "Hello Worlddddddddddddddddddddddd", .05f, true);
    }
    public void setText(string messages) 
    {
        this.messages = messages;
    }
}
