using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogManager : MonoBehaviour
{
    public Text messageText;
    Message[] currentMessages;
    int activeMessage = 0;
    //public static bool isActive = false;
    

    [SerializeField] private TextWriter textWriter;

    private void Awake()
    {
        messageText = transform.Find("messageText").GetComponent<Text>();
    }


    public void OpenDialog(Message[] messages) 
    {
        //gameObject.SetActive(true);
        //isActive = true;
        currentMessages = messages;
        activeMessage = 0;
        Debug.Log("Stared conversasssstion! Loaded messages: " + messages.Length);
        DisplayMessage();

    }


    void DisplayMessage() 
    {
        Message messageToDisplay = currentMessages[activeMessage];
        //messageText.text = messageToDisplay.message;
        textWriter.AddWriter(messageText, messageToDisplay.message, .05f, true);
    }


    public void NextMessage() 
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else 
        {
            Debug.Log("Conversation ended!");
            //isActive = false;
            //messageText.text = "";
            gameObject.SetActive(false);
        }
    }


    public void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && isActive == true) 

        if (Input.GetKeyDown(KeyCode.Space) && gameObject.activeSelf == true) 
        {
            NextMessage();
        }
    }
}
