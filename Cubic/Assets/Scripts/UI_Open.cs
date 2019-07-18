using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UI_Open : MonoBehaviour
{
    public GameObject UI_Elements;
   
    void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
    }


    private void EndReached(VideoPlayer vp)
    {
        
        UI_Elements.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
