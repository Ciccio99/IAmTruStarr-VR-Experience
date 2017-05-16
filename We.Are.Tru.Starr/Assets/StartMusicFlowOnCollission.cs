using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusicFlowOnCollission : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Player")
        {
            SceneMusicFlowManger.instance.StartMusicFlow();
            Debug.Log("Started Music flow");
        }
    }
}
