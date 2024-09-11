using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameController : MonoBehaviour
{
    static GameController _instant;
    public static GameController Instant => _instant;
    [SerializeField] BtnLetter _prefabBtn;
    [SerializeField] string _demoLetters;

    [SerializeField] Transform _btnManager;


    List<Text> _answerLetters = new List<Text>();
    [SerializeField] Transform _answerManager;

    int _currentIndex = 0;

    private void Awake() {
        _instant = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        this.Init();
    }

    void Init(){
        _demoLetters = _demoLetters.ToUpper();
        for(int  i = 0; i< _demoLetters.Length; i++){
            Instantiate(_prefabBtn,_btnManager.transform).Init(_demoLetters[i]);
        }

        _answerLetters = _answerManager.GetComponentsInChildren<Text>().ToList();

    }

    public void AssignLetter(char letter){
        this._answerLetters[this._currentIndex].text = letter.ToString();
    }
}
