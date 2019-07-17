using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Player_Fix : MonoBehaviour
{
    public VideoPlayer videoPlayer1, videoPlayer2, videoPlayer3, videoPlayer4, videoPlayer5, videoPlayer6;
    void Start()
    {
        videoPlayer1.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S1a");
        /*videoPlayer2.url = System.IO.Path.Combine(Application.streamingAssetsPath, "02_10_Loop.mp4");
        videoPlayer3.url = System.IO.Path.Combine(Application.streamingAssetsPath, "03_45_Once.mp4");
        videoPlayer4.url = System.IO.Path.Combine(Application.streamingAssetsPath, "04_05_Loop.mp4");
        videoPlayer5.url = System.IO.Path.Combine(Application.streamingAssetsPath, "05_60_Once.mp4");
        videoPlayer6.url = System.IO.Path.Combine(Application.streamingAssetsPath, "06_15_Loop.mp4");*/
    }

}
