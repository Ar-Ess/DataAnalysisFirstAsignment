using System;
using UnityEngine;

public class AnalysisRecolector : MonoBehaviour
{
    [SerializeField] private string url;

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
        user.SendData(url);
    }

    public void OnNewSession(DateTime date)
    {
        SessionData session = new SessionData(date, true);
        session.SendData(url);
    }

    public void OnEndSession(DateTime date)
    {
        SessionData session = new SessionData(date, false);
        session.SendData(url);
    }

    public void OnBuyItem(int id, DateTime date)
    {
        BuyData buy = new BuyData(id, date);
        buy.SendData(url);
    }
}
