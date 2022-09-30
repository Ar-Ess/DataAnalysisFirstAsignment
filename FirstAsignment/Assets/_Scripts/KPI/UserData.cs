using System;
using System.Collections;
using UnityEngine;

public class UserData
{
    public UserData(string name, string country, DateTime date)
    {
        this.name = name;
        this.country = country;
        this.date = date;
    }

    public IEnumerator SendData(string url)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            //www.date = date;
            //www.name = name;
            //www.county = country;
        }
    }

    DateTime date;
    string name;
    string country;
}
