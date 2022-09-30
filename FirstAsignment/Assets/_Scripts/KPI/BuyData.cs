using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class BuyData
{
    public BuyData(int id, DateTime date)
    {
        this.id = id;
        this.date = date;
    }

    public IEnumerator SendData(string url)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            //www.date = date;
            //www.id = id;
        }
    }

    DateTime date;
    int id;
}