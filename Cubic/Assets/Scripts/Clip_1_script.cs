using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Clip_1_script : MonoBehaviour
{
    public GameObject Next_video, UI_Elemnts;

    void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
    }

   private void EndReached(VideoPlayer vp)
    {
        Next_video.SetActive(true);
        UI_Elemnts.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
