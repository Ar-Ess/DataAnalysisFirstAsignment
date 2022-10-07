using System;
using System.Collections;
using UnityEngine;

public class AnalysisManager : MonoBehaviour
{
    [SerializeField] private string url = null;

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
        SessionData session = new SessionData(date, true);
        StartCoroutine(SendData(session.ProcessData(), 1));
    }

    public void OnEndSession(DateTime date)
    {
        SessionData session = new SessionData(date, false);
        StartCoroutine(SendData(session.ProcessData(), 2));
    }

    public void OnBuyItem(int id, DateTime date)
    {
        BuyData buy = new BuyData(id, date);
        StartCoroutine(SendData(buy.ProcessData(), 3));
    }

    public IEnumerator SendData(WWWForm form, int type)
    {
        WWW www = new WWW(url, form);

        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }

        int id = int.Parse(www.text);

        switch (type)
        {
            case 0: CallbackEvents.OnAddPlayerCallback.Invoke((uint)id) ; break;

            case 1: CallbackEvents.OnNewSessionCallback.Invoke((uint)id); break;

            case 2: CallbackEvents.OnEndSessionCallback.Invoke((uint)id); break;

            case 3: CallbackEvents.OnItemBuyCallback.Invoke()           ; break;
        }

    }
}
