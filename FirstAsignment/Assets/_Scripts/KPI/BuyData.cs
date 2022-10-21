using System;
using UnityEngine;

public class BuyData
{
    public BuyData(int id, DateTime date, int playerId)
    {
        this.id = id;
        this.date = date;
        this.playerId = playerId;

    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();
        form.AddField("b_date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        form.AddField("b_id", id);
        form.AddField("p_id", playerId);

        //Debug.Log(id + " " + date + " " + playerId);

        return form;
    }

    DateTime date;
    int id;
    int playerId;

}