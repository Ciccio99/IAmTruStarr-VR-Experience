using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAddOnCollission : MonoBehaviour
{

    public string sceneToLoad;

    private void Awake()
    {
        if (sceneToLoad == "") {
            sceneToLoad = "Warp_01";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            GameSceneManager.instance.LoadScene(sceneToLoad);
        }
    }
}
