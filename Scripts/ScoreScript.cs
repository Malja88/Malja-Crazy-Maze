using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] Text score;
    [SerializeField] Text stageScore;
    [Header("Gameobjects")]
    [SerializeField] GameObject nextRoundScene;
    [SerializeField] GameObject TimerScreen;
    [SerializeField] GameObject door;
    [SerializeField] GameObject key;
    [SerializeField] GameObject hint;
    [SerializeField] GameObject death;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] MeshRenderer mesh;
    [Header("Audio")]
    [SerializeField] AudioSource victory;
    [SerializeField] AudioSource levelMusic;
    [SerializeField] AudioSource coin;
    [SerializeField] AudioSource deathSFX;
    int coinScore;
    int crystalCount;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coinScore++;
            score.text = coinScore.ToString();
            stageScore.text = coinScore.ToString();
        }
        if(other.gameObject.CompareTag("Finish"))
        {
            TimerScreen.SetActive(false);
            nextRoundScene.SetActive(true);
            victory.Play();
            levelMusic.Stop();
        }
        if(other.gameObject.CompareTag("Key"))
        {
            door.SetActive(false);
            coin.Play();
            Destroy(key);
            Destroy(hint);
        }
        if(other.gameObject.CompareTag("Enemy"))
        {
            deathSFX.Play();
            Destroy(mesh);
            death.SetActive(true);
            StartCoroutine(GameOverScreen());
        }
        if (other.gameObject.CompareTag("Crystal"))
        {
            crystalCount++;
            Destroy(other.gameObject);
            if(crystalCount == 2)
            {
                door.SetActive(false);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Door"))
        {
            hint.SetActive(true);
        }
    }
    IEnumerator GameOverScreen()
    {
        yield return new WaitForSeconds(1);
        {
            gameOverScreen.SetActive(true);
            levelMusic.Stop();
            Destroy(this.gameObject);
        }
    }
}
