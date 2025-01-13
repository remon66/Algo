using Meta.XR.ImmersiveDebugger.UserInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class ChangeColor : MonoBehaviour
{
    public Light spotlight;

    // Start is called before the first frame update
    void Start()
    {
        spotlight = GameObject.Find("Spotlight").GetComponent<Light>();
        spotlight.enabled = true;
    }

    // Update is called once per frame
    public void SetColor()
    {
        Console.print(this.gameObject.GetComponent<XRSlider>().value);
        if (this.gameObject.GetComponent<XRSlider>().value < 0.2f && this.gameObject.GetComponent<XRSlider>().value >= 0)
        {
            spotlight.color = Color.yellow;
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.4f && this.gameObject.GetComponent<XRSlider>().value >= 0.2)
        {
            spotlight.color = Color.red;
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.6f && this.gameObject.GetComponent<XRSlider>().value >= 0.4f)
        {
            spotlight.color = Color.green;
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.8f && this.gameObject.GetComponent<XRSlider>().value >= 0.6f)
        {
            spotlight.color = Color.magenta;
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 1 && this.gameObject.GetComponent<XRSlider>().value >= 0.8f)
        {
            spotlight.color = Color.blue;
        }
        else
        {
            spotlight.color = Color.black;
        }
    }
}
