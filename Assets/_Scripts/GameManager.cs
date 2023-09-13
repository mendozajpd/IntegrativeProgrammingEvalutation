using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public BackgroundTransition TransitionScreen;
    public Animator WrongX;
    private AudioSource _audio;
    private AudioClip _ding;
    private AudioClip _strike;

    [Header("Scene Handlers")]
    public string NextScene;
    public string PreviousScene;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _ding = Resources.Load<AudioClip>("Ding");
        _strike = Resources.Load<AudioClip>("Strike");
    }
    void Start()
    {
        TransitionScreen.PlayFadeIn();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WrongX.SetTrigger("Wrong");
            PlayStrike();
        }

        if (Input.GetKeyDown(KeyCode.Comma))
        {
            if (PreviousScene != "") LoadScene(PreviousScene);
        }

        if (Input.GetKeyDown(KeyCode.Period))
        {
            if (NextScene != "") LoadScene(NextScene);
        }
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayDing()
    {
        _audio.clip = _ding;
        _audio.PlayOneShot(_audio.clip);
    }

    public void PlayStrike()
    {
        _audio.clip = _strike;
        _audio.PlayOneShot(_audio.clip);
    }
}
