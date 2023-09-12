using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundTransition : MonoBehaviour
{
    private Image _blackScreen;
    private Animator _anim;

    private void Awake()
    {
        _blackScreen = GetComponent<Image>();
        _anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayFadeIn()
    {
        _anim.Play("FadeIn");
    }

    public void PlayFadeOut()
    {
        _anim.Play("FadeOut");
    }

}
