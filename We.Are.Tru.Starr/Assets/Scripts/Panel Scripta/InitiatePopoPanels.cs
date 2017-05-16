using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class InitiatePopoPanels : MonoBehaviour {

    public GameObject player;
    public GameObject mainCam;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject popoCarPanel;
    public GameObject speechBubble;
    public GameObject smokeBlastParticleSystem;

    private float distanceFromPlayer = 6.0f;
    private float panel_1_time = 2.0f;
    private float panel_2_time = 4.0f;

    private Vector3 smokePos;
    private GameObject activePanel;
    private Vector3 prevPanelPos;

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
            Debug.Log(mainCam.name);
            mainCam.GetComponent<Bloom>().enabled = true;
        }

        Invoke("SpawnSmokeBlast", 1.1f);
        Invoke("SpawnPanel1", 1.2f);
        Invoke("SpawnPopoCar", 1.2f);

    }

    // Update is called once per frame
    void Update()
    {
        if (activePanel != null)
        {
            RotateTowardsPlayer();
        }

        if (speechBubble.activeSelf) {
            RotateTowardsPlayer(speechBubble);
        }
    }

    private void OnDestroy()
    {
        mainCam.GetComponent<Bloom>().enabled = false;
    }

    private void SpawnSmokeBlast() {
        if (smokePos == new Vector3(0f,0f,0f)) {
            smokePos = getPosFrontPlayer(distanceFromPlayer - 0.5f);
        }

        Instantiate(smokeBlastParticleSystem, smokePos, Quaternion.identity);
    }

    private void SpawnPopoCar() {
        SetPanelPosition(distanceFromPlayer + 2.0f, popoCarPanel);
        RotateTowardsPlayer(popoCarPanel);
        popoCarPanel.SetActive(true);
    }

    private void SpawnPanel1()
    {
        activePanel = panel1;
        SetPanelPosition(distanceFromPlayer);
        prevPanelPos = activePanel.transform.position;
        RotateTowardsPlayer();
        panel1.SetActive(true);
        Invoke("SpawnPanel2", panel_1_time);
    }

    private void SpawnPanel2()
    {
        activePanel.SetActive(false);
        activePanel = panel2;
        activePanel.transform.position = prevPanelPos;
        RotateTowardsPlayer();
        activePanel.SetActive(true);
        Vector3 look = Quaternion.LookRotation(player.transform.position).eulerAngles.normalized;
        Vector3 bubblePos = activePanel.transform.position + new Vector3(look.x, 0f, look.z) + (new Vector3(0.5f, 1f,-0.5f)) * 2f;
        speechBubble.transform.position = bubblePos;
        speechBubble.SetActive(true);
        Invoke("SpawnSmokeBlast", panel_2_time - 0.3f);
        Invoke("RemoveThis", panel_2_time);
    }

    void DespawnActivePanel()
    {
        activePanel.SetActive(false);
    }

    // Returns the positions a specified distance from the player
    private Vector3 getPosFrontPlayer(float distance)
    {
        return new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    // Sets the position of the active a specified distance from the player
    void SetPanelPosition(float distance)
    {
        activePanel.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.2f, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    // Sets the position of the passed in object a certain distance from the panel
    void SetPanelPosition(float distance, GameObject panel)
    {
        panel.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.2f, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    void RotateTowardsPlayer()
    {
        Vector3 lookPos = player.transform.position - activePanel.transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        activePanel.transform.rotation = rotation;
        activePanel.transform.Rotate(0, 180.0f, 0);
    }

    void RotateTowardsPlayer(GameObject panel) {
        Vector3 lookPos = player.transform.position - panel.transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        panel.transform.rotation = rotation;
        panel.transform.Rotate(0, 180.0f, 0);
    }

    private void RemoveThis()
    {
        Destroy(gameObject);
    }
}
