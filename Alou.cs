using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;
using System;
using UnityEngine.SceneManagement;

public class Alou : MonoBehaviour
{
    static UdpClient udpClient;
    [SerializeField] private bool vertical = true;
    [SerializeField] private bool horizontal = true;

    [SerializeField] private float limitX;
    [SerializeField] private float limitY;
    [SerializeField] private float inicial_x = 9999;
    [SerializeField] private int final_x = 9999;
    [SerializeField] private float inicial_y = 9999;
    [SerializeField] private int final_y = 9999;
    [SerializeField] private int portNum = 9999;
    [SerializeField] private string currentScene;
    [SerializeField] private GameObject avatar;
    [SerializeField] private float speed = 3f; // move speed
    [SerializeField] private Vector2 inicialPosition;
    [SerializeField] private float monitorX;
    [SerializeField] private float monitorY;
    [SerializeField] private bool gameStart = true; 
    [SerializeField] private Rigidbody2D m_Rigidbody;
    [SerializeField] private float m_Thrust = 20f;

    private void Start()
    {   
        print("Start");
        
        try{
            udpClient = new UdpClient(portNum);
            
        }catch(Exception e){
            print(e);
        }
    }

    void Update()
    {   

        currentScene = SceneManager.GetActiveScene().name;
        if(currentScene == "fase-1" || currentScene == "fase-2" || currentScene == "fase-3" || currentScene == "cofre-1" || currentScene == "cofre-2" || currentScene == "cofre-3" || currentScene == "cofre-4"){
                  
            avatar = GameObject.FindGameObjectWithTag("Character");

            m_Rigidbody = avatar.GetComponent<Rigidbody2D>();

            
            monitorX = avatar.transform.position.x;
            monitorY= avatar.transform.position.y;

            try{
                IPEndPoint remoteEP = null;
                byte[] data = udpClient.Receive(ref remoteEP);
                string message = Encoding.ASCII.GetString(data);  

                string aux = message.Replace(" ", "");

                string[] coordenates = aux.Split(','); 
                

                if(coordenates.Length == 2){
                    print("passou 1");
                    float x = float.Parse(coordenates[0]);
                    float y = float.Parse(coordenates[1]);
                    
                    float x_posi =  x*-1;
                    float y_posi =  y*-1;
                   

                    if((x_posi > inicial_x && x < final_x)  && (y_posi > inicial_y && y < final_y)){
                        gameStart = true;
                        print(gameStart);
                    }


                    if(gameStart){

                        
                        print("passou 2");
                        monitorX = Mathf.Sign(x)*speed;
                        monitorY = Mathf.Sign(y)*speed;
                        
                        print($"{monitorX}, {monitorY}");
    
                    
                    m_Rigidbody.velocity=(new Vector3(monitorX, monitorY));
                }
            }
            }catch(Exception e){
                print(e);
            }
        
        }
        
    }
}
