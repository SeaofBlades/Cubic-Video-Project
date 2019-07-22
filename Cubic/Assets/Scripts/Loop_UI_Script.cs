using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_UI_Script : MonoBehaviour
{
    public GameObject Next_vid, cur_vid, UI_Element;
    public Video_Player_Fix Vid_Fix;

    void Start()
    {
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_vid);
        Vid_Fix.next.Add(UI_Element);
    }
    public void Next_video()
    {
        Next_vid.SetActive(true);
        UI_Element.SetActive(true);
        cur_vid.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
