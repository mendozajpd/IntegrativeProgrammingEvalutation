using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BackgroundTransition TransitionScreen;
    public Animator WrongX;
    void Start()
    {
        TransitionScreen.PlayFadeIn();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            WrongX.SetTrigger("Wrong");
        }
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator loadAfterDelay(float delay, string sceneName)
    {
        yield return new WaitForSeconds(delay);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
