using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] SFXscript sound;
public void PlayButton()
    {
        sound.OnClick();
        StartCoroutine(StartScene());
    }

    public void QuitGame()
    {
        Application.Quit();
        sound.OnClick();
    }

    public void Creator()
    {
        sound.OnClick();
    }

    public void Restart()
    {
        sound.OnClick();
        StartCoroutine(RestartScene());
    }
    public void MainMenu()
    {
        sound.OnClick();
        SceneManager.LoadScene(0);
    }
    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameObject.SetActive(false);
    }
}
