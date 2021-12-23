namespace StirlingLabs.LsQuic.Native
{
    public enum LSQUIC_CONN_STATUS
    {
        LSCONN_ST_HSK_IN_PROGRESS,
        LSCONN_ST_CONNECTED,
        LSCONN_ST_HSK_FAILURE,
        LSCONN_ST_GOING_AWAY,
        LSCONN_ST_TIMED_OUT,
        LSCONN_ST_RESET,
        LSCONN_ST_USER_ABORTED,
        LSCONN_ST_ERROR,
        LSCONN_ST_CLOSED,
        LSCONN_ST_PEER_GOING_AWAY,
        LSCONN_ST_VERNEG_FAILURE,
    }
}