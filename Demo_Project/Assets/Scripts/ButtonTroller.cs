using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTroller : MonoBehaviour
{
    public GameObject bton1, bton2, bton3, bton4, mstrCard, vsCard, nmBtn, hkIdBtn, dtOfBirth, phnNo, eMl;
    public Text mstrCardText, vsCardText, nmBtnText, hkIDText, dtOfBirthText, phnNoText, eMlText;
    public int surviceStatus; //1=Insurence, 2=Cash, 3=Loan, 4=Cresitcard;
    private Text uiText;
    [SerializeField] private TextWriter textWriter;

    private void Awake()
    {
        uiText = transform.Find("dialogBox").Find("messageText").GetComponent<Text>();
        mstrCardText = transform.Find("Selection1").Find("Text").GetComponent<Text>();
        vsCardText = transform.Find("Selection2").Find("Text").GetComponent<Text>();
        nmBtnText = transform.Find("InputName").Find("Text").GetComponent<Text>();
        hkIDText = transform.Find("InputHKID").Find("Text").GetComponent<Text>();
        dtOfBirthText = transform.Find("InputDOB").Find("Text").GetComponent<Text>();
        phnNoText = transform.Find("InputPhnNo").Find("Text").GetComponent<Text>();
        eMlText = transform.Find("InputEml").Find("Text").GetComponent<Text>();
    }

    public void PressBT1()
    {
        bton1.SetActive(false);
        bton2.SetActive(false);
        bton3.SetActive(false);
        bton4.SetActive(false);
        surviceStatus = 1;
    }

    public void PressBT2()
    {
        bton1.SetActive(false);
        bton2.SetActive(false);
        bton3.SetActive(false);
        bton4.SetActive(false);
        surviceStatus = 2;
    }

    public void PressBT3()
    {
        bton1.SetActive(false);
        bton2.SetActive(false);
        bton3.SetActive(false);
        bton4.SetActive(false);
        surviceStatus = 3;
    }

    public void PressBT4()
    {
        bton1.SetActive(false);
        bton2.SetActive(false);
        bton3.SetActive(false);
        bton4.SetActive(false);
        mstrCard.SetActive(true);
        vsCard.SetActive(true);
        mstrCardText.text = "MasterCard";
        vsCardText.text = "Visa";
        surviceStatus = 4;
    }

    public void PressBTQuit()
    {
        textWriter.AddWriter(uiText, "What Can I Help You?", .05f, true);
        bton1.SetActive(true);
        bton2.SetActive(true);
        bton3.SetActive(true);
        bton4.SetActive(true);
        mstrCard.SetActive(false);
        vsCard.SetActive(false);
        hkIdBtn.SetActive(false);
        nmBtn.SetActive(false);
        dtOfBirth.SetActive(false);
        phnNo.SetActive(false);
        eMl.SetActive(false);
        surviceStatus = 0;

    }

    public void PressMstrCDBtn()
    {
        mstrCard.SetActive(false);
        vsCard.SetActive(false);
        nmBtn.SetActive(true);
        nmBtnText.text = "Name";

    }

    public void PressnmBtn()
    {
        nmBtn.SetActive(true);
        hkIdBtn.SetActive(true);
        hkIDText.text = "HKID";
    }

    public void PressHKIDBtn()
    {
        hkIdBtn.SetActive(false);
        dtOfBirth.SetActive(true);
        dtOfBirthText.text = "DateOfBirth";
    }
    public void PressdtOBtn()
    {
        dtOfBirth.SetActive(false);
        phnNo.SetActive(true);
        phnNoText.text = "PhoneNo.";
    }

    public void PressPhoneNo()
    {
        phnNo.SetActive(false);
        eMl.SetActive(true);
        eMlText.text = "Email";
    }

    public void PressEMal()
    {
        phnNo.SetActive(false);
        eMl.SetActive(false);
    }

    public int GetSurviceStatus()
    {
        return surviceStatus;
    }

    public void ButtonDecter()
    {
        
    }


}
