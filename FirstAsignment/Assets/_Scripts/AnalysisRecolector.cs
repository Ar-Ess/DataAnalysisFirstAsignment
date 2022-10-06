using System;
using UnityEngine;

public class AnalysisRecolector : MonoBehaviour
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
        StartCoroutine(user.SendData(url));
    }

    public void OnNewSession(DateTime date)
    {
        SessionData session = new SessionData(date, true);
        StartCoroutine(session.SendData(url));
    }

    public void OnEndSession(DateTime date)
    {
        SessionData session = new SessionData(date, false);
        StartCoroutine(session.SendData(url));
    }

    public void OnBuyItem(int id, DateTime date)
    {
        BuyData buy = new BuyData(id, date);
        StartCoroutine(buy.SendData(url));
    }
}
