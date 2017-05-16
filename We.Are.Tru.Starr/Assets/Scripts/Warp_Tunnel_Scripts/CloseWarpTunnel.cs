using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWarpTunnel : MonoBehaviour {
    public string previousSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TruStarrPlayer") {
            Debug.Log("Close tunnels");
            Destroy(other.gameObject.GetComponent<moveTowardsWarpTunnel>());
            // Close the previous scene
            GameSceneManager.instance.Unload(previousSceneName);
            // Close the warp tunnel scene
            GameSceneManager.instance.Unload(gameObject.scene.name);
        }
    }

}
