using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class twichMessage : MonoBehaviour
{
    private TwitchIRC IRC;
    public Chatter latestChatter;
    public UnityEvent LightOff, RadioOn, CambiaPacco, MorphPacco, SpillOil, InsertFakePackage, ForkliftOn, FallShelves, WrongLocationNews, FakeNews, TellRealLocation;
    public float lightCooldown;
    public float radioCooldown;
    public float cambioPaccoCooldown;
    public float MorphPaccoCooldown;
    public float spillOilCooldown;
    public float InsertFakePackageCooldown;
    public float ForkliftCooldown;
    public float FallShelvesCooldown;
    public float WrongLocationNewsCooldown;
    public float FakeNewsCooldown;
    public float TellRealLocationCooldown;
    private bool canLight;
    private bool canRadio;
    private bool canCambioPacco;
    private bool canMorphPacco;
    private bool canSpillOil;
    private bool canInsertFakePackage;
    private bool canForklift;
    private bool canFallShelves;
    private bool canWrongNews;
    private bool canfakeNews;
    private bool canTellRealLocation;



    private void Awake()
        {
            // Place TwitchIRC.cs script on an gameObject called "TwitchIRC"
            IRC = GameObject.Find("TwitchIRC").GetComponent<TwitchIRC>();

            // Add an event listener
            IRC.newChatMessageEvent.AddListener(NewMessage);
            canLight = true;
            canRadio = true;
            canCambioPacco = true;
            canMorphPacco = true;
            canSpillOil = true;
            canInsertFakePackage = true;
            canForklift = true;
            canFallShelves = true;
            canWrongNews = true;
            canfakeNews = true;
            canTellRealLocation = true;
        }

        // This gets called whenever a new chat message appears
        public void NewMessage(Chatter chatter)
        {
        latestChatter = chatter;
        if (chatter.message.ToLower() == "light off")
        {
            if (canLight)
            {
                LightOff.Invoke();
                canLight = false;
                StartCoroutine(lightCountdown());
            }            
        }
        else if(chatter.message.ToLower() == "radio on")
        {
            if (canRadio)
            {
                RadioOn.Invoke();
                canRadio = false;
                StartCoroutine(radioCountdown());
            }
        }
        else if (chatter.message.ToLower() == "swap package")
        {
            if (canCambioPacco)
            {
                CambiaPacco.Invoke();
                canCambioPacco = false;
                StartCoroutine(cambioPaccoCountdown());
            }
        }
        else if (chatter.message.ToLower() == "morph package")
        {
            if (canMorphPacco)
            {
                MorphPacco.Invoke();
                canMorphPacco = false;
                StartCoroutine(morphPaccoCountdown());
            }
        }
        else if (chatter.message.ToLower() == "spill oil")
        {
            if (canSpillOil)
            {
                SpillOil.Invoke();
                canSpillOil = false;
                StartCoroutine(spillOilCountdown());
            }
        }
        else if (chatter.message.ToLower() == "fall shelves")
        {
            if (canFallShelves)
            {
                FallShelves.Invoke();
                canFallShelves = false;
                StartCoroutine(fallShelvesCountdown());
            }
        }
        else if (chatter.message.ToLower() == "fake news")
        {
            if (canfakeNews)
            {
                FakeNews.Invoke();
                canfakeNews = false;
                StartCoroutine(fakeNewsCountdown());
            }
        }
        else if (chatter.message.ToLower() == "fake location")
        {            
            if (canWrongNews)
            {
                WrongLocationNews.Invoke();
                canWrongNews = false;
                StartCoroutine(wrongNewsCountdown());
            }
        }
        else if (chatter.message.ToLower() == "real location")
        {            
            if (canTellRealLocation)
            {
                TellRealLocation.Invoke();
                canTellRealLocation = false;
                StartCoroutine(realLocationCountdown());
            }
        }
        else if (chatter.message.ToLower() == "fake package")
        {
           
            if (canInsertFakePackage)
            {
                InsertFakePackage.Invoke();
                canInsertFakePackage = false;
                StartCoroutine(fakePackageCountdown());
            }
        }
        else if (chatter.message.ToLower() == "forklift on")
        {
            if (canForklift)
            {
                ForkliftOn.Invoke();
                canForklift = false;
                StartCoroutine(forkliftCountdown());
            }
        }
    }

    IEnumerator forkliftCountdown()
    {
        yield return new WaitForSeconds(ForkliftCooldown);
        canForklift = true;
    }

    IEnumerator fakePackageCountdown()
    {
        yield return new WaitForSeconds(InsertFakePackageCooldown);
        canInsertFakePackage = true;
    }

    IEnumerator realLocationCountdown()
    {
        yield return new WaitForSeconds(WrongLocationNewsCooldown);
        canTellRealLocation = true;
    }

    IEnumerator wrongNewsCountdown()
    {
        yield return new WaitForSeconds(WrongLocationNewsCooldown);
        canWrongNews = true;
    }

    IEnumerator fakeNewsCountdown()
    {
        yield return new WaitForSeconds(FakeNewsCooldown);
        canfakeNews = true;
    }

    IEnumerator fallShelvesCountdown()
    {
        yield return new WaitForSeconds(FallShelvesCooldown);
        canFallShelves = true;
    }

    IEnumerator spillOilCountdown()
    {
        yield return new WaitForSeconds(spillOilCooldown);
        canSpillOil = true;
    }

    IEnumerator morphPaccoCountdown()
    {
        yield return new WaitForSeconds(MorphPaccoCooldown);
        canMorphPacco = true;
    }

    IEnumerator cambioPaccoCountdown()
    {
        yield return new WaitForSeconds(cambioPaccoCooldown);
        canCambioPacco = true;
    }

    IEnumerator radioCountdown()
    {
        yield return new WaitForSeconds(radioCooldown);
        canRadio = true;
    }

    IEnumerator lightCountdown()
    {
        yield return new WaitForSeconds(lightCooldown);
        canLight = true;
    }

}
