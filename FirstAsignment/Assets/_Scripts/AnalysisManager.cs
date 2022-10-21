using System;
using System.Collections;
using UnityEngine;

public class AnalysisManager : MonoBehaviour
{
    [SerializeField] private string[] url = null;
    private int currentPlayerId = 0;
    private int currentSessionId = 0;

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
        SessionData session = new SessionData(date, false, currentSessionId);
        StartCoroutine(SendData(session.ProcessData(), 2));
    }

    public void OnBuyItem(int id, DateTime date)
    {
        BuyData buy = new BuyData(id, date, currentSessionId);
        StartCoroutine(SendData(buy.ProcessData(), 3));
    }

    public IEnumerator SendData(WWWForm form, int type)
    {
        WWW www = new WWW(url[type], form);

        yield return www;
        
        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }


        switch (type)
        {
            case 0:
                currentPlayerId = int.Parse(www.text);
                CallbackEvents.OnAddPlayerCallback.Invoke((uint)currentPlayerId);
                break;

            case 1:
                currentSessionId = int.Parse(www.text);
                CallbackEvents.OnNewSessionCallback.Invoke((uint)currentPlayerId);
                break;

            case 2: 
                CallbackEvents.OnEndSessionCallback.Invoke((uint)currentSessionId); 
                break;

            case 3: 
                CallbackEvents.OnItemBuyCallback.Invoke(); 
                break;
        }

    }
}
