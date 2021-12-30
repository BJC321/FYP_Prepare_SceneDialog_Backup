using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    private Text uiText;
    private string textTowrite;
    private int characterIndex;
    private float timePerCharacter;
    private float timer;
    private bool invisibleCharacters;

    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter, bool invisibleCharacters)
    {
        this.uiText = uiText;
        this.textTowrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
        this.invisibleCharacters = invisibleCharacters;
        characterIndex = 0;
    }

    private void Update()
    {
        if (uiText != null) 
        {
            timer -= Time.deltaTime;
            while (timer <= 0.0f) 
            {
                //Display next character
                timer += timePerCharacter;
                characterIndex++;
                string text = textTowrite.Substring(0, characterIndex);
                if (invisibleCharacters) 
                {
                    text += "<color=#00000000>" + textTowrite.Substring(characterIndex) + "</color>";
                }
                uiText.text = text;
                if (characterIndex >= textTowrite.Length) 
                {
                    //Enter string displayed
                    uiText = null;
                    return;
                }
            }
        }
    }
}
