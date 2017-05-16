using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluxBluePopoLight : MonoBehaviour
{
    public float speed = 5;

    private Light blueLight;
    private float count;

    private void Awake()
    {
        if (blueLight== null)
        {
            blueLight = GetComponent<Light>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime ;
        blueLight.intensity = Mathf.Abs(Mathf.Cos(count * speed));
    }
}
