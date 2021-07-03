using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject vic, juca, lila, leo, nina, caio;
    void Start()
    {
       string avatar = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().getAvatar();
       
       switch(avatar){

           case "vic":
            
            vic.SetActive(true);
            
            break;

           case "juca":
            
            juca.SetActive(true);
            
            break;

           case "lila":
            
            lila.SetActive(true);
            
            break;
        
           case "leo":
            
            leo.SetActive(true);
            
            break;

           case "nina":
            
            nina.SetActive(true);
            
            break;

           case "caio":
            
            caio.SetActive(true);
            
            break;

           default: 

           nina.SetActive(true);

           break;
       }
       
    }

  

}
