using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtains : MonoBehaviour
{


    public GameObject curtainsClosed;
    public GameObject curtainsOpen;

    public void toggleCurtains()
    {
        if (curtainsClosed.activeSelf)
        {
            curtainsClosed.SetActive(false);
            curtainsOpen.SetActive(true);
        }else
        {
            curtainsClosed.SetActive(true);
            curtainsOpen.SetActive(false);
        }
    }
}
