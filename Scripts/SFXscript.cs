using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXscript : MonoBehaviour
{
    [SerializeField] public AudioSource click;
    public void OnClick()
    {
        click.Play();
    }
}
