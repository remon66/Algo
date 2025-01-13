using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Remote : MonoBehaviour
{

    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GameObject.Find("Cinema").GetComponent<VideoPlayer>();
    }

    public void playVideo()
    {
        videoPlayer.Play();
    }
}
