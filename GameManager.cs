using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string avatar;

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public string getAvatar(){
        return this.avatar;
    }
    public void setAvatar(string avatar){
        this.avatar = avatar;
    }
}
