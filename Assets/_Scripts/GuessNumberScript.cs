using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuessNumberScript : MonoBehaviour
{
    public bool ShowAnswer;
    public int GuessNumber;
    public string Answer;

    [SerializeField] private GameManager gameManager;
    private TextMeshProUGUI _boxText;
    private Animator _anim;

    private void Awake()
    {
        _boxText = GetComponentInChildren<TextMeshProUGUI>();
        _anim = GetComponent<Animator>();
        if (_boxText != null) _boxText.text = GuessNumber.ToString();

    }
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(GuessNumber.ToString()))
        {
            Debug.Log(GuessNumber + " was pressed");
            ShowAnswer = ShowAnswer ? false : true;
            if (ShowAnswer)
            {
                gameManager.PlayDing();
                _boxText.text = Answer;
            }
            else
            {
                _boxText.text = GuessNumber.ToString();
            }
            _anim.SetTrigger("Correct");

        }
    }


}
