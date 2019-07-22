using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Next_Scene : MonoBehaviour
{
    public GameObject Next_Object;
    public Video_Player_Fix Curr_vid;

    private void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
        Curr_vid.next.Clear();
        Curr_vid.next.Add(Next_Object);
    }
    void OnEnable()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
        Curr_vid.next.Clear();
        Curr_vid.next.Add(Next_Object);
    }


    private void EndReached(VideoPlayer vp)
    {
        Curr_vid.active.Clear();
        Curr_vid.active.Add(Next_Object);
        Next_Object.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
