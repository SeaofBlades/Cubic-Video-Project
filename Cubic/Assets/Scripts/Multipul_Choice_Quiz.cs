using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Multipul_Choice_Quiz : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public string Question_text;
        public List<Answer> Answers;
    }
    [System.Serializable]
    public class Answer
    {
        public string Answer_text;
        public bool correct;
    }

    public List<Question> Question_List;
    public GameObject Pause_Button, answer1_button, answer2_button, answer3_button;
    public TextMeshProUGUI Question_Text, answer1_text, answer2_text, answer3_text;
    bool triva_finished = false, triva_started = false;

    

    private void FixedUpdate()
    {
        Pause_Button.SetActive(triva_finished);
        if (triva_finished == false && triva_started == false)
        {

        }
    }

    //EventSystem.current.currentSelectedGameObject.name
}
