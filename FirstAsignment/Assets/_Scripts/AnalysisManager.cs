﻿using System;
using System.Collections;
using UnityEngine;

public class AnalysisManager : MonoBehaviour
{
    [SerializeField] private string[] userURL = null;
    private int currentPlayerId = 0;

    private void OnEnable()
    {
        Simulator.OnNewPlayer += OnNewPlayer;
        Simulator.OnNewSession += OnNewSession;
        Simulator.OnEndSession += OnEndSession;
        Simulator.OnBuyItem += OnBuyItem;
    }

    public void OnNewPlayer(string name, string country, DateTime date)
    {
        UserData user = new UserData(name, country, date);
        StartCoroutine(SendData(user.ProcessData(), 0));
    }

    public void OnNewSession(DateTime date)
    {
        SessionData session = new SessionData(date, true, currentPlayerId);
        StartCoroutine(SendData(session.ProcessData(), 1));
    }

    public void OnEndSession(DateTime date)
    {
        SessionData session = new SessionData(date, false, currentPlayerId);
        StartCoroutine(SendData(session.ProcessData(), 2));
    }

    public void OnBuyItem(int id, DateTime date)
    {
        BuyData buy = new BuyData(id, date);
        StartCoroutine(SendData(buy.ProcessData(), 3));
    }

    public IEnumerator SendData(WWWForm form, int type)
    {
        WWW www = new WWW(userURL[type], form);

        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }


        switch (type)
        {
            case 0:
            CallbackEvents.OnAddPlayerCallback.Invoke((uint)currentPlayerId);
            currentPlayerId = int.Parse(www.text);
            break;

            case 1: CallbackEvents.OnNewSessionCallback.Invoke((uint)currentPlayerId); break;

            case 2: CallbackEvents.OnEndSessionCallback.Invoke((uint)currentPlayerId); break;

            case 3: CallbackEvents.OnItemBuyCallback.Invoke(); break;
        }

    }
}
