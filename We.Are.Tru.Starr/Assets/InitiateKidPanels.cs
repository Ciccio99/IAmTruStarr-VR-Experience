using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;


public class InitiateKidPanels : MonoBehaviour {
    public GameObject player;
    public GameObject mainCam;
    public GameObject panel1;
    public GameObject hydrant;
    public GameObject smokeBlastParticleSystem;

    private float distanceFromPlayer = 5.0f;
    private float deathTimer = 8.0f;

    private GameObject spawnedHydrant;
    private GameObject activePanel;
    private Vector3 currPos;

    // Use this for initialization
    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("TruStarrPlayer");
        }

        if (mainCam == null)
        {
            mainCam = GameObject.Find("Head");
            mainCam.GetComponent<Bloom>().enabled = true;
        }

        // Set position of parent object
        SetPanelPosition(distanceFromPlayer);

        Invoke("SpawnSmokeBlast", 0.9f);
        Invoke("SpawnPanels", 1);

    }

    private void OnDestroy()
    {
        mainCam.GetComponent<Bloom>().enabled = false;
    }

    private void SpawnSmokeBlast()
    {
        Vector3 smokePos = (player.transform.position - transform.position).normalized * 2 + transform.position;
        Instantiate(smokeBlastParticleSystem, smokePos, Quaternion.identity);
    }


    private void SpawnPanels()
    {
        panel1.SetActive(true);
        hydrant.SetActive(true);
        Invoke("SpawnSmokeBlast", deathTimer - 0.1f);
        Invoke("RemoveThis", deathTimer);
    }

    // Sets the position of the active a specified distance from the player
    void SetPanelPosition(float distance)
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 0.3f, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    private void RemoveThis()
    {
        Destroy(gameObject);
    }
}
