using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomRoomPlayer : NetworkRoomPlayer
{
    public override void OnStartClient()
    {
        Debug.Log($"�÷��̾� {netId}�� Ŭ���̾�Ʈ���� ����");
    }

    public override void ReadyStateChanged(bool oldReadyState, bool newReadyState)
    {
        Debug.Log($"�÷��̾� {netId}�� �غ� ���� : {newReadyState}");
    }
}
