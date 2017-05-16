using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

    public static GameSceneManager instance { set; get; }

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start() {
        LoadScene("Start_Scene");
        LoadScene("Player");
    }

    public void LoadScene(string sceneName) {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded) {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }
    }

    public void Unload(string sceneName) {
        if (SceneManager.GetSceneByName(sceneName).isLoaded) {
            SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}
