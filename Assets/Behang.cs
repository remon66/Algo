using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR.Content.Interaction;

public class Behang : MonoBehaviour
{
    public Material[] materials;
    public GameObject Object;


    public void ChangeMaterial()
    {
        if (this.gameObject.GetComponent<XRSlider>().value < 0.2f && this.gameObject.GetComponent<XRSlider>().value >= 0)
        {
            Object.GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.4f && this.gameObject.GetComponent<XRSlider>().value >= 0.2)
        {
            Object.GetComponent<MeshRenderer>().material = materials[1];
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.6f && this.gameObject.GetComponent<XRSlider>().value >= 0.4f)
        {
            Object.GetComponent<MeshRenderer>().material = materials[2];
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 0.8f && this.gameObject.GetComponent<XRSlider>().value >= 0.6f)
        {
            Object.GetComponent<MeshRenderer>().material = materials[3];
        }
        else if (this.gameObject.GetComponent<XRSlider>().value < 1 && this.gameObject.GetComponent<XRSlider>().value >= 0.8f)
        {
            Object.GetComponent<MeshRenderer>().material = materials[4];
        }
        else
        {
            Object.GetComponent<MeshRenderer>().material = materials[5];
        }
    }
}
