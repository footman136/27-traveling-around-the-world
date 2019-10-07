using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Gamelogic.FSM;

public class GamePlayFabLoginState : FsmBaseState<ConnectionStateMachine, ConnectionFSMStateEnum.StateEnum>
{
    private readonly ConnectionManager _connection;

    private GameObject _panelConnecting;

    public GamePlayFabLoginState(ConnectionStateMachine owner, ConnectionManager connection) : base(owner)
    {
        _connection = connection;
    }

    public override void Enter()
    {
        _panelConnecting = UIManager.CreatePanel(UIManager.Instance.RootLobby, "", "UI/Logo/PanelConnecting");
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
