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
    public SessionData(DateTime date, bool start)
    {
        this.date = date;
        state = start ? SessionState.SESSION_START : SessionState.SESSION_END;
    }

    public WWWForm ProcessData()
    {
        WWWForm form = new WWWForm();
        int s = (int)state;

        form.AddField("s_date", date.ToString("yyyy-MM-dd HH:mm:ss"));
        form.AddField("state", s);

        return form;
    }

    DateTime date;
    SessionState state;
}
