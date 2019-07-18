using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Player_Fix : MonoBehaviour
{
    public VideoPlayer S1a, S1b, S2a, S2b, S2d, S3a, S3a_Loop, S3b, S3b_Loop, S4a, S4b, S4c_Loop, S5a_Loop, S5b, S6a, S7a, S7b, S7c;
    void Start()
    {
        S1a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S1a.mp4");
        S1b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S1b.mp4");
        S2a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2a.mp4");
        S2b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2b.mp4");
        S2d.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2d.mp4");
        S3a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S3a.mp4");
    }

}
