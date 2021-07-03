using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{

    [SerializeField] private string scene;

    public void changeScene(){
        SceneManager.LoadScene(scene);
        print("cliqueii");
    }
}