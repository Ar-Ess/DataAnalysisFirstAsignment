using System;
using UnityEngine;

public class UserData
{
    public UserData(string name, string country, DateTime date)
    {
        this.name = name;
        this.country = country;
        this.date = date;
    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("country", country);
        form.AddField("u_date", date.ToString("yyyy-MM-dd HH:mm:ss"));

        return form;
    }

    DateTime date;
    string name;
    string country;
}
