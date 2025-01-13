using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public Light spotlight;

    // Start is called before the first frame update
    void Start()
    {
        spotlight = GameObject.Find("Spotlight").GetComponent<Light>();
        spotlight.enabled = true;
    }

    public void toggleLights()
    {
        if (spotlight.enabled)
        {
            spotlight.enabled = false;
        }
        else
        {
            spotlight.enabled = true;
        }
    }
}
