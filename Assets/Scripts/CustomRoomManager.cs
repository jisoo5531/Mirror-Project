using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomRoomManager : NetworkRoomManager
{
    /// <summary>
    /// 방에 플레이어가 들어왔을 때
    /// </summary>
    /// <param name="conn"></param>
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Debug.Log($"플레이어가 방에 입장하였습니다.");
    }

    /// <summary>
    /// 모든 플레이어가 준비 상태일 때
    /// </summary>
    public override void OnRoomServerPlayersReady()
    {
        Debug.Log($"모든 플레이어가 준비 완료");
        base.OnRoomServerPlayersReady();
    }
}
