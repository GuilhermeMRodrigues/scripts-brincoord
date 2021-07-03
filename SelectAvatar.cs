using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectAvatar : MonoBehaviour
{
 
    [SerializeField] private string avatar;
    [SerializeField] private string scene;
    public void SelecAvatarInChangeScene(){

        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().setAvatar(avatar);
        SceneManager.LoadScene(scene);
        
    }
        
}
