using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_UI_Script : MonoBehaviour
{
    public GameObject Next_vid, cur_vid, UI_Element;
    public Video_Player_Fix Vid_Fix;

    private void Start()
    {
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_vid);
        Vid_Fix.next.Add(UI_Element);
    }
    void OnEnable()
    {
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_vid);
        Vid_Fix.next.Add(UI_Element);
    }
    public void Next_video()
    {
        Vid_Fix.active.Clear();
        Vid_Fix.active.Add(Next_vid);
        Vid_Fix.active.Add(UI_Element);
        Next_vid.SetActive(true);
        UI_Element.SetActive(true);
        cur_vid.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
