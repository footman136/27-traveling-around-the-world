using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Gamelogic.FSM;

public class GameConnectingState : FsmBaseState<ConnectionStateMachine, ConnectionFSMStateEnum.StateEnum>
{
    private readonly ConnectionManager _connection;

    private GameObject _clientWorker;
    private GameObject _panelConnecting;
    
    public GameConnectingState(ConnectionStateMachine owner, ConnectionManager connection) : base(owner)
    {
        _connection = connection;
    }

    public override void Enter()
    {
        _panelConnecting = UIManager.CreatePanel(UIManager.Instance.RootLogo, "", "UI/Logo/PanelConnecting");
        
        // 使用PlayFab链接后台数据库
        // clientWorker一启动，就会连接服务器
//        _clientWorker = ConnectionManager.Instance.ClientConnector.gameObject;
//        _clientWorker.SetActive(true);
    }

    public override void Tick()
    {
    }

    public override void Exit(bool disabled)
    {
        if (_panelConnecting != null)
        {
            UIManager.DestroyPanel(ref _panelConnecting);
        }
    }
}
