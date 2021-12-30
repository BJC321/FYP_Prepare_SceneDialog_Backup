using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageControl : MonoBehaviour
{
    public List<string> message;

    void Update()
    {
        switch (FindObjectOfType<ButtonTroller>().GetSurviceStatus())
        {
            case 1 :
                message.Add("Here are two types of /nCredit Card application.");
                message.Add("Please input the informarion of /n applicant name.");
                message.Add("Please input the informarion of /n applicant's HongKong ID Card Number.");
                message.Add("Please input the informarion of /n applicant's Date of Birth");
                message.Add("Please input the informarion of /n applicant's Phone Number");
                message.Add("Please input the informarion of /n applicant's Date of Birth");
                break;

            case 2:

                break;

            case 3:

                break;

            case 4:

                break;
            default:
                for (int i = 0;i< message.Count; i++)
                {
                    message.RemoveAt(i);
                }
                break;
        }
    }

}
