using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;
    public GameObject dialogBox;
    public Text dialogBoxMessage;

    public void Start()
    {
        GameObject.Find("xbot").GetComponent<AnimationControl>().PlayAFK();
    }

    public void StartDialog() 
    {
        if (dialogBox.activeSelf == false)
        {
            dialogBoxMessage.text = "";
            dialogBox.SetActive(true);
        }
        FindObjectOfType<DialogManager>().OpenDialog(messages);

        GameObject.Find("xbot").GetComponent<AnimationControl>().PlayAnimation();
    }

}

[System.Serializable]
public class Message
{
    public string message;
}
