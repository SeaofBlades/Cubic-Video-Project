using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Player_Fix : MonoBehaviour
{
    public VideoPlayer S1a, S1b, S2a, S2b, S2d, S3a, S3a_Loop, S3b, S3b_Loop, S4a_Loop, S4b, S4c_Loop, S5a_Loop, S5b, S6a, S7a, S7b, S7c;
    [Header("Pause")]
    public List<GameObject> active, next;
    public GameObject pause_menu, pause_button, default_scene;

    void Start()
    {
        S1a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S1a.mp4");
        S1b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S1b.mp4");
        S2a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2a.mp4");
        S2b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2b.mp4");
        S2d.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S2d.mp4");
        S3a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S3a.mp4");
        S3a_Loop.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S3a-Loop.mp4");
        S3b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S3b.mp4");
        S3b_Loop.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S3b-Loop.mp4");
        S5a_Loop.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S5a-Loop.mp4");
        S5b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S5b.mp4");
        S7a.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S7a.mp4");
        S7b.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S7b.mp4");
        S7c.url = System.IO.Path.Combine(Application.streamingAssetsPath, "S7c.mp4");
    }



    public void Pause_Video()
    {
        for (int i = 0; i < active.Count; i++)
        {
            if (active[i].GetComponent<VideoPlayer>())
            {
                active[i].GetComponent<VideoPlayer>().Pause();
            }
            else
            {
                active[i].SetActive(false);
            }
        }
        pause_button.SetActive(false);
        pause_menu.SetActive(true);
    }

    public void Continue()
    {
        for (int i = 0; i < active.Count; i++)
        {
            if (active[i].GetComponent<VideoPlayer>())
            {
                active[i].GetComponent<VideoPlayer>().Play();
            }
            else
            {
                active[i].SetActive(true);
            }
        }
        pause_button.SetActive(true);
        pause_menu.SetActive(false);
    }

    public void Restart()
    {
        for (int i = 0; i < active.Count; i++)
        {
            active[i].SetActive(false);
        }
        active.Clear();
        active.Add(default_scene);
        default_scene.SetActive(true);
        pause_button.SetActive(false);
        pause_menu.SetActive(false);
    }

    public void Skip_Scene()
    {
        List<GameObject> Curr_next = new List<GameObject>();
        for (int i = 0; i < next.Count; i++)
        {
            Curr_next.Add(next[i]);
        }
        next.Clear();
        for (int i = 0; i < active.Count; i++)
        {
            active[i].SetActive(false);
        }
        active.Clear();
        for (int i = 0; i < Curr_next.Count; i++)
        {
            active.Add(Curr_next[i]);
            Curr_next[i].SetActive(true);
        }
        pause_button.SetActive(true);
        pause_menu.SetActive(false);
    }

}
