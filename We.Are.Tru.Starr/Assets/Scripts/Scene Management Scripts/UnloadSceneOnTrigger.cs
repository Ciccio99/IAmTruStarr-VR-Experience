using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnloadSceneOnTrigger : MonoBehaviour {

    public string sceneName;

    private void Awake()
    {
        if (sceneName == "") {
            sceneName = "Start_Scene";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            GameSceneManager.instance.Unload(sceneName);         
        }
    }
}
