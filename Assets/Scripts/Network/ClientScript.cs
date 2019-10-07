/// <summary>
/// Client Script.
/// Created By 蓝鸥3G 2014.08.23
/// https://www.cnblogs.com/daxiaxiaohao/p/4402063.html
/// </summary>

using UnityEngine;
using System.Collections;

public class ClientScript: MonoBehaviour {
    string msg = "";
    // Use this for initialization

    TcpSocket client;
    void Start () {
        client = TcpSocket.GetSocket(TcpSocket.LOSocketType.CLIENT);
        client.InitClient ("127.0.0.1", 2222, ((string content) => {
            //收到服务器的回馈信息
        }));
    }

    void OnGUI() {
        msg = GUI.TextField(new Rect(0, 0, 500, 40), msg);
        if(GUI.Button(new Rect(0, 50, 100, 30), "Send"))
        {

            client.SendMessage (msg);
        }
    }
} 