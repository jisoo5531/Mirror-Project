using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomRoomPlayer : NetworkRoomPlayer
{
    public override void OnStartClient()
    {
        Debug.Log($"플레이어 {netId}가 클라이언트에서 시작");
    }

    public override void ReadyStateChanged(bool oldReadyState, bool newReadyState)
    {
        Debug.Log($"플레이어 {netId}의 준비 상태 : {newReadyState}");
    }
}
