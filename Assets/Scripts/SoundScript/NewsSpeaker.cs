using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsSpeaker : MonoBehaviour
{
    private AudioClip[] FakeNewsAudio;
    private AudioClip[] fallShelvesAudio;
    private AudioClip[] forkliftAudio;
    private AudioClip[] lightAudio;
    private AudioClip[] oilAudio;
    private AudioClip[] rageAudio;
    private AudioClip[] swapAudio;
    private AudioClip[] radioAudio;
    private AudioClip[] teleportAudio;

    public List<string> fakeLocation;
    public string locationPackage;

    // Start is called before the first frame update
    void Start()
    {
        fallShelvesAudio = Resources.LoadAll<AudioClip>("Sound/fallshelves");
        FakeNewsAudio = Resources.LoadAll<AudioClip>("Sound/fakeNews");
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
        
    }


}
