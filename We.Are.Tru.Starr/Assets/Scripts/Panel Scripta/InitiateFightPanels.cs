using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class InitiateFightPanels : MonoBehaviour {

    public GameObject player;
    public GameObject mainCam;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject smokeBlastParticleSystem;


    private GameObject activePanel;
    private Vector3 smokePos;
    private float distanceFromPlayer = 4;
    private float panel_1_time = 2.0f;
    private float panel_2_time = 2.0f;
    private float panel_3_time = 2.0f;
    private float panel_4_time = 1.0f;

    // Use this for initialization
    void Start () {
        if (player == null) {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (mainCam == null) {
            mainCam = GameObject.Find("Head");
            mainCam.GetComponent<Bloom>().enabled = true;
        }

        Invoke("SpawnSmokeBlast", 1.8f);
        Invoke("SpawnPanel1", 2);
	}

    // Update is called once per frame
    void Update()
    {
        if (activePanel != null)
        {
            RotateTowardsPlayer();
        }
    }

    private void OnDestroy()
    {
        mainCam.GetComponent<Bloom>().enabled = false;
    }

    private void SpawnSmokeBlast()
    {
        if (smokePos == new Vector3(0f, 0f, 0f))
        {
            smokePos = getPosFrontPlayer(distanceFromPlayer - 0.5f);
        }

        Instantiate(smokeBlastParticleSystem, smokePos, Quaternion.identity);
    }

    private void SpawnPanel1() {
        activePanel = panel1;
        SetPanelPosition(distanceFromPlayer);
        panel1.SetActive(true);
        Invoke("SpawnPanel2", panel_1_time);
    }

    private void SpawnPanel2 () {
        activePanel.SetActive(false);
        activePanel = panel2;
        SetPanelPosition(distanceFromPlayer - 1f);
        activePanel.SetActive(true);
        Invoke("SpawnPanel3", panel_2_time);
    }

    private void SpawnPanel3()
    {
        activePanel.SetActive(false);
        activePanel = panel3;
        SetPanelPosition(distanceFromPlayer - 2f);
        activePanel.SetActive(true);
        Invoke("SpawnPanel4", panel_3_time);
    }

    private void SpawnPanel4()
    {
        activePanel.SetActive(false);
        activePanel = panel4;
        SetPanelPosition(distanceFromPlayer - 3.5f);
        activePanel.SetActive(true);
        Invoke("RemoveThis", panel_4_time);
    }

    void DespawnActivePanel() {
        activePanel.SetActive(false);
    }

    void SetPanelPosition(float distance) {
        activePanel.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.2f, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    private Vector3 getPosFrontPlayer(float distance)
    {
        return new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) + (new Vector3(mainCam.transform.forward.x, 0, mainCam.transform.forward.z) * distance);
    }

    void RotateTowardsPlayer() {
        Vector3 lookPos = player.transform.position - activePanel.transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        activePanel.transform.rotation = rotation;
        activePanel.transform.Rotate(0, 180.0f, 0);
    }

    private void RemoveThis() {
        Destroy(gameObject);
    }
}
