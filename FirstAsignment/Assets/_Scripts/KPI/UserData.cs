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
        Debug.Log(name);
        WWWForm form = new WWWForm();
        form.AddField("name", name);

        Debug.Log(form.data.GetValue(1));
        form.AddField("country", country);
        form.AddField("date", date.ToString("yyyy-MM-dd HH:mm:ss"));

        WWW www = new WWW(url, form);
        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }
        else Debug.Log(www.text);
    }

    DateTime date;
    string name;
    string country;
}
