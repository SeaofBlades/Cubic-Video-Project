using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Loop_2_script : MonoBehaviour
{
    public GameObject Next_vid, cur_vid;
    public Video_Player_Fix Vid_Fix;

    private void Start()
    {
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_vid);
    }
    void OnEnable()
    {
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_vid);
    }
    public void Next_video()
    {
        Vid_Fix.active.Clear();
        Vid_Fix.active.Add(Next_vid);
        Next_vid.SetActive(true);
        cur_vid.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
