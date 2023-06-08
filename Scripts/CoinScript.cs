using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] GameObject particle;
    [SerializeField] AudioSource coinCollect;
    private void OnTriggerEnter(Collider other)
    {
        coinCollect.Play();
        this.gameObject.SetActive(false);
        particle.SetActive(true);
        StartCoroutine(CoinDestroy());
    }
    IEnumerator CoinDestroy()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}
