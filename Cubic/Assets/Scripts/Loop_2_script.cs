using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Loop_2_script : MonoBehaviour
{
    public GameObject Next_vid, cur_vid, panel;
   public void Open_Panel()
    {
        panel.SetActive(true);
    }

    public void Close_Panel()
    {
        panel.SetActive(false);
    }

    public void Next_video()
    {
        Next_vid.SetActive(true);
        cur_vid.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
