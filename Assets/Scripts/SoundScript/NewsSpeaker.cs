
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
    public AudioClip introAudio;

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
        //playlist = new List<AudioClip>();
        playlist.Add(introAudio);
        
        StartCoroutine(nextAudio());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator nextAudio()
    {
        while (true)
        {
            if (audioPlayer != null)
            {
                if (!audioPlayer.isPlaying && (playlist[0] != null))
                {
                    yield return new WaitForSeconds(3f);
                    audioPlayer.clip = playlist[0];
                    audioPlayer.Play();
                    playlist.Remove(playlist[0]);
                }
            }
        }
    }
    public void addAudioFallShelves()
    {
        int i = Random.Range(0, fallShelvesAudio.Length - 1);
        playlist.Add(fallShelvesAudio[i]);
    }
    public void addAudioFakeNews()
    {
        int i = Random.Range(0, fakeNewsAudio.Length - 1);
        playlist.Add(fakeNewsAudio[i]);
    }
    public void addAudioForklift()
    {
        int i = Random.Range(0, forkliftAudio.Length - 1);
        playlist.Add(forkliftAudio[i]);
    }
    public void addAudioLight()
    {
        int i = Random.Range(0, lightAudio.Length - 1);
        playlist.Add(lightAudio[i]);
    }
    public void addAudioOil()
    {
        int i = Random.Range(0, oilAudio.Length - 1);
        playlist.Add(oilAudio[i]);
    }
    public void addAudioRage()
    {
        int i = Random.Range(0, rageAudio.Length - 1);
        playlist.Add(rageAudio[i]);
    }
    public void addAudioSwap()
    {
        int i = Random.Range(0, swapAudio.Length - 1);
        playlist.Add(swapAudio[i]);
    }
    public void addAudioRadio()
    {
        int i = Random.Range(0, radioAudio.Length - 1);
        playlist.Add(radioAudio[i]);
    }
    public void addAudioTeleport()
    {
        int i = Random.Range(0, teleportAudio.Length - 1);
        playlist.Add(teleportAudio[i]);
    }
}
