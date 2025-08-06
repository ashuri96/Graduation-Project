using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

/// <summary>
/// Mirrorのネットワーク接続を制御するUIを管理するクラス
/// </summary>
public class NetworkManagerUI : MonoBehaviour
{
    /// <summary>
    /// ホスト/クライアント/サーバーボタンが配置されているCanvas
    /// 接続を開始したら非表示にするために使用
    /// </summary>
    [Tooltip("接続ボタンなどが配置されているCanvasオブジェクト")]
    public Canvas canvas;

    /// <summary>
    /// [Host]ボタンが押されたときに呼び出される関数
    /// </summary>
    public void OnHostButton()
    {
        // 同じGameObjectにアタッチされているNetworkManagerの機能を使ってホストとして起動する
        // ホスト：サーバーを起動し、自身もクライアントとしてそのサーバーに参加する
        GetComponent<NetworkManager>().StartHost();

        // 接続を開始したら、ボタンが押せないようにUIを非表示にする
        canvas.gameObject.SetActive(false);
    }

    /// <summary>
    /// [Client]ボタンが押されたときに呼び出される関数
    /// </summary>
    public void OnClientButton()
    {
        // 接続先となるサーバーのIPアドレスを指定する
        // "localhost"は自分自身のPCを指すため、テスト時に便利
        GetComponent<NetworkManager>().networkAddress = "localhost";

        // 同じGameObjectにアタッチされているNetworkManagerの機能を使ってクライアントとして起動する
        // クライアント：指定したIPアドレスのサーバーに接続を試みる
        GetComponent<NetworkManager>().StartClient();

        // 接続を開始したら、ボタンが押せないようにUIを非表示にする
        canvas.gameObject.SetActive(false);
    }

    /// <summary>
    /// [Server Only]ボタンが押されたときに呼び出される関数
    /// </summary>
    public void OnServerButton()
    {
        // 同じGameObjectにアタッチされているNetworkManagerの機能を使ってサーバーとして起動する
        // サーバー専用：プレイヤーとしては参加せず、接続を待ち受けるだけのサーバーを立てる
        GetComponent<NetworkManager>().StartServer();

        // 接続を開始したら、ボタンが押せないようにUIを非表示にする
        canvas.gameObject.SetActive(false);
    }
}