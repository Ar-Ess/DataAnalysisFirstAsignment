using System;
using System.Collections;
using UnityEngine;

enum SessionState
{
    SESSION_START,
    SESSION_END

}

public class SessionData
{
    public SessionData(DateTime date, bool start, int id)
    {
        this.date = date;
        this.id = id;
        state = start ? SessionState.SESSION_START : SessionState.SESSION_END;
    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();
        int s = (int)state;

        form.AddField("s_date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        form.AddField("s_id", id);

        //Debug.Log(date);

        return form;
    }

    DateTime date;
    SessionState state;
    int id = -1;
}
