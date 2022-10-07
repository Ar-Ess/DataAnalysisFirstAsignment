using System;
using UnityEngine;

public class BuyData
{
    public BuyData(int id, DateTime date)
    {
        this.id = id;
        this.date = date;
    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();
        form.AddField("date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        form.AddField("id", id.ToString());

        return form;
    }

    DateTime date;
    int id;
}