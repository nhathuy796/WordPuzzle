using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnLetter : MonoBehaviour
{
    char _letter;
    public char Letter => _letter;
    Text _childText;

    Button _btn;

     
    public BtnLetter Init(char letter){

        if(_btn == null)
            this._btn = this.GetComponent<Button>();

        if(_childText == null)
            this._childText = this.GetComponentInChildren<Text>();
        
        this._childText.text = letter.ToString();
        this._letter = letter;

        this._btn.onClick.AddListener(AssignLetter);
        return this;
    }

    void AssignLetter(){
        GameController.Instant.AssignLetter(this._letter);
    }
}
