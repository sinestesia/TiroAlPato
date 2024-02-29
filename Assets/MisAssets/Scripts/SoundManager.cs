using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static SoundManager instancia;

    [SerializeField] private AudioClip disparo;
    [SerializeField] private AudioClip impacto;


    private void Awake()
    {
        instancia = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void SonidoDisparo()
    {
        audioSource.PlayOneShot(disparo);
    }
    public void SonidoImpacto()
    {
        audioSource.PlayOneShot(impacto);
    }
}
