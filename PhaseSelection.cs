using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhaseSelection : MonoBehaviour
{

    [SerializeField] private string character = "Character";
    [SerializeField] private string scene;

    private void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == character) {
            print("aaaaa");
            changeScene(scene);
        }
         Debug.LogWarning(col.gameObject.tag + " : " + gameObject.name + " : " + Time.time);
    }

    private void changeScene(string scene) {
        SceneManager.LoadScene(scene);
    }
}