using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Clip_1_script : MonoBehaviour
{
    public GameObject Next_video, UI_Elemnts;
    public Video_Player_Fix Vid_Fix;

    void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_video);
        Vid_Fix.next.Add(UI_Elemnts);
    }

   private void EndReached(VideoPlayer vp)
    {
        Next_video.SetActive(true);
        UI_Elemnts.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
