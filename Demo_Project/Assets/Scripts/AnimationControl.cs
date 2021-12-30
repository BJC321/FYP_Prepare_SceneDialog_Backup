using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    private Animation AFK;
    private Animation Typing;
    

    public void PlayAnimation()
    {
        int Number = Random.Range(0, 4);

        switch (Number)
        {
            case 1:
                GetComponent<Animation>().Play("Typing");
                break;
            case 2:
                GetComponent<Animation>().Play("AFK");
                break;
            case 3:
                GetComponent<Animation>().Play("SittingTalking");
                break;
            case 4:
                GetComponent<Animation>().Play("ShakingHands");
                break;

           

        }

        //if(Number <= 0)
        //{
        //    GetComponent<Animation>().Play("Typing");
        //}

        //if(Number == 1)
        //{
        //    GetComponent<Animation>().Play("AFK");
        //}        
    }

    public void PlayAFK()
    {
        GetComponent<Animation>().Play("AFK");
    }
}
