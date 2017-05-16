using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusicFlowManger : MonoBehaviour {

    public static SceneMusicFlowManger instance { set; get; }

    private AudioSource song;

    private void Start()
    {
        if (instance == null) {
            instance = this;
        }

        if (song == null) {
            song = GetComponent<AudioSource>();
        }
    }


    public void StartMusicFlow() {
        song.Play();
        InitPreChorus();
    }

    public void InitPreChorusCD() {
  
    }

    private void InitPreChorus() {
        GameSceneManager.instance.LoadScene("Warp_0");
        InitFirstChorusCD();
    }

    public void InitFirstChorusCD() {
        Invoke("InitFirstChorus", 62);
        Debug.Log("InitFirstChoursCD");
    }

    private void InitFirstChorus() {
        GameSceneManager.instance.LoadScene("Warp_01");
        InitVerseCD();
    }

    public void InitVerseCD() {
        Invoke("InitVerse", 62);
        Debug.Log("INITVERSECD");
    }

    private void InitVerse() {
        GameSceneManager.instance.LoadScene("Warp_02");
        InitSecondChorusCD();
    }

    public void InitSecondChorusCD () {
        Debug.Log("Initiation second chours");
        Invoke("InitSecondChorus", 62);
    }
    private void InitSecondChorus() {
        GameSceneManager.instance.LoadScene("Warp_03");
    }

}
