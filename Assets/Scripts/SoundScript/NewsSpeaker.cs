﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsSpeaker : MonoBehaviour
{
    private AudioClip[] fakeNewsAudio;
    private AudioClip[] fallShelvesAudio;
    private AudioClip[] forkliftAudio;
    private AudioClip[] lightAudio;
    private AudioClip[] oilAudio;
    private AudioClip[] rageAudio;
    private AudioClip[] swapAudio;
    private AudioClip[] radioAudio;
    private AudioClip[] teleportAudio;
    private List<AudioClip> playlist;
    public AudioSource audioPlayer;

    public List<string> fakeLocation;
    public string locationPackage;

    // Start is called before the first frame update
    void Start()
    {
        fallShelvesAudio = Resources.LoadAll<AudioClip>("Sound/fallshelves");
        fakeNewsAudio = Resources.LoadAll<AudioClip>("Sound/fakeNews");
        forkliftAudio = Resources.LoadAll<AudioClip>("Sound/forklift");
        lightAudio = Resources.LoadAll<AudioClip>("Sound/light");
        oilAudio = Resources.LoadAll<AudioClip>("Sound/oil");
        rageAudio = Resources.LoadAll<AudioClip>("Sound/rage");
        swapAudio = Resources.LoadAll<AudioClip>("Sound/swap");
        radioAudio = Resources.LoadAll<AudioClip>("Sound/telefono");
        teleportAudio = Resources.LoadAll<AudioClip>("Sound/teleport");
    }

    // Update is called once per frame
    void Update()
    {
        if (audioPlayer != null) {
            if (!audioPlayer.isPlaying) {
                playlist.Remove(playlist[0]);
                if (playlist[0] != null)
                {
                    StartCoroutine(nextAudio());
                }
            }
        }
    }

    IEnumerator nextAudio()
    {
        yield return new WaitForSeconds(3f);
        audioPlayer.clip = playlist[0];
        audioPlayer.Play();
    }
    void addAudioFallShelves()
    {
        int i = Random.Range(0, fallShelvesAudio.Length - 1);
        playlist.Add(fallShelvesAudio[i]);
    }
    void addAudioFakeNews()
    {
        int i = Random.Range(0, fakeNewsAudio.Length - 1);
        playlist.Add(fakeNewsAudio[i]);
    }
    void addAudioForklift()
    {
        int i = Random.Range(0, forkliftAudio.Length - 1);
        playlist.Add(forkliftAudio[i]);
    }
    void addAudioLight()
    {
        int i = Random.Range(0, lightAudio.Length - 1);
        playlist.Add(lightAudio[i]);
    }
    void addAudioOil()
    {
        int i = Random.Range(0, oilAudio.Length - 1);
        playlist.Add(oilAudio[i]);
    }
    void addAudioRage()
    {
        int i = Random.Range(0, rageAudio.Length - 1);
        playlist.Add(rageAudio[i]);
    }
    void addAudioSwap()
    {
        int i = Random.Range(0, swapAudio.Length - 1);
        playlist.Add(swapAudio[i]);
    }
    void addAudioRadio()
    {
        int i = Random.Range(0, radioAudio.Length - 1);
        playlist.Add(radioAudio[i]);
    }
    void addAudioTeleport()
    {
        int i = Random.Range(0, teleportAudio.Length - 1);
        playlist.Add(teleportAudio[i]);
    }
}
