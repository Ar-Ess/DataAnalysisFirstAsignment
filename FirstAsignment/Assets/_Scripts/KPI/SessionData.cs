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

    public IEnumerator SendData(string url)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            //www.date = date;
            //www.state = (int)state;
        }
    }

    DateTime date;
    SessionState state;
}
