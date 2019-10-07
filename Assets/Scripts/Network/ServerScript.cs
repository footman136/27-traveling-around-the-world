/// <summary>
/// Server Script.
/// Created By 蓝鸥3G 2014.08.23
/// https://www.cnblogs.com/daxiaxiaohao/p/4402063.html
/// </summary>
/// 
/// 
using UnityEngine;
using System.Collections;

public class ServerScript : MonoBehaviour {

    private string receive_str;
    TcpSocket server;
    // Use this for initialization
    void Start () 
    {
        server = TcpSocket.GetSocket(TcpSocket.LOSocketType.SERVER);
        //初始化服务器
        server.InitServer((string content) => {
            receive_str = content;
        });
    }

    void OnGUI()
    {
        if (receive_str != null) 
        {
            GUILayout.Label (receive_str);
        }
    }
}