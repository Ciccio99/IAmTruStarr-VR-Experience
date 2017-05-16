using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddSceneOnTrigger : MonoBehaviour {

    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TruStarrPlayer") {
            GameSceneManager.instance.LoadScene(sceneName);
        }
    }
}
