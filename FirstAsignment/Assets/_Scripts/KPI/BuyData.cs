using System;
using UnityEngine;

public class BuyData
{
    public BuyData(int id, DateTime date, int sessionId)
    {
        this.id = id;
        this.date = date;
        this.sessionId = sessionId;
    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();

        form.AddField("b_date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        form.AddField("b_id", id);
        form.AddField("s_id", sessionId);

        return form;
    }

    DateTime date;
    int id;
    int sessionId;

}