using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomRoomManager : NetworkRoomManager
{
    /// <summary>
    /// �濡 �÷��̾ ������ ��
    /// </summary>
    /// <param name="conn"></param>
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Debug.Log($"�÷��̾ �濡 �����Ͽ����ϴ�.");
    }

    /// <summary>
    /// ��� �÷��̾ �غ� ������ ��
    /// </summary>
    public override void OnRoomServerPlayersReady()
    {
        Debug.Log($"��� �÷��̾ �غ� �Ϸ�");
        base.OnRoomServerPlayersReady();
    }
}
