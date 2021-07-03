using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.Net;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class Pula : MonoBehaviour
{
    static UdpClient udpClient;
    [SerializeField] private string scene;
    [SerializeField] private int portNum = 7777;

    // Start is called before the first frame update
    void Start()
    {              
        try{
            udpClient = new UdpClient(portNum);
            
        }catch(Exception e){
            print(e);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        IPEndPoint remoteEP = null;
        byte[] data = udpClient.Receive(ref remoteEP);
        string message = Encoding.ASCII.GetString(data);
        print(message);
        if(message == "True"){
            SceneManager.LoadScene(scene);
        }
    }
}
