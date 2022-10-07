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


        form.AddField("country", country);
        form.AddField("date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        

        WWW www = new WWW(url, form);

        
        

        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }

        int id = int.Parse(www.text);
        Debug.Log("id" + id);
        CallbackEvents.OnAddPlayerCallback.Invoke((uint)id);
      
        
        CallbackEvents.OnNewSessionCallback.Invoke((uint)id);
        CallbackEvents.OnEndSessionCallback.Invoke((uint)id);
        CallbackEvents.OnItemBuyCallback.Invoke();
    }

    DateTime date;
    string name;
    string country;
}
