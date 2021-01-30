using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class twichMessage : MonoBehaviour
{
        private TwitchIRC IRC;
        public Chatter latestChatter;
    /*
        public UnityEvent randomEvent;
        public UnityEvent MoveforwordEvent;
        public UnityEvent MovebackEvent;
        public UnityEvent MoveLeftEvent;
        public UnityEvent MoveRightEvent;
        [Space(10)]
        public UnityEvent DashforwordEvent;
        public UnityEvent DashbackEvent;
        public UnityEvent DashLeftEvent;
        public UnityEvent DashRightEvent;
        public UnityEvent JumpEvent;*/

    public UnityEvent LightOffEvent;
    public UnityEvent RadioOnEvent;
    public UnityEvent CambiaPaccoEvent;

    private void Awake()
        {
            // Place TwitchIRC.cs script on an gameObject called "TwitchIRC"
            IRC = GameObject.Find("TwitchIRC").GetComponent<TwitchIRC>();

            // Add an event listener
            IRC.newChatMessageEvent.AddListener(NewMessage);
        }

        // This gets called whenever a new chat message appears
        public void NewMessage(Chatter chatter)
        {
        /*
            if (chatter.message == "random move")
            {
              randomEvent.Invoke();
            }else if(chatter.message == "move forward")
            {
              MoveforwordEvent.Invoke();
            }else if(chatter.message == "move back")
            {
              MovebackEvent.Invoke();
            }else if(chatter.message == "move left")
            {
              MoveLeftEvent.Invoke();
            }else if(chatter.message == "move right")
            {
              MoveRightEvent.Invoke();
            }else if(chatter.message == "dash forword")
            {
              DashforwordEvent.Invoke();
            }else if(chatter.message == "dash back")
            {
              DashbackEvent.Invoke();
            }else if(chatter.message == "dash left")
            {
              DashLeftEvent.Invoke();
            }else if(chatter.message == "dash right")
            {
              DashRightEvent.Invoke();
            }else if(chatter.message == "jump")
            {
              JumpEvent.Invoke();
            }
        */

        if(chatter.message == "turn off light")
        {
            LightOffEvent.Invoke();
        }else if(chatter.message == "radio on")
        {
            RadioOnEvent.Invoke();
        }else if(chatter.message == "shift pacco")
        {
            CambiaPaccoEvent.Invoke();
        }

        }
    }
