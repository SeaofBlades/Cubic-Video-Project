using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Next_Scene : MonoBehaviour
{
    public GameObject Next_Object;
   
    void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
    }


    private void EndReached(VideoPlayer vp)
    {
        
        Next_Object.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
