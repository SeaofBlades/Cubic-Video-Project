using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer_Bool : MonoBehaviour
{
    public bool Is_correct;
    public GameObject Next_button, Answerbutton1, Answerbutton2;
    public NEW_Multipul_choice_quiz scorecard;

    public void Question_answer()
    {
        if (Is_correct == true)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            scorecard.score++;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.red;
            if (Answerbutton1.GetComponent<Answer_Bool>().Is_correct == true)
            {
                Answerbutton1.GetComponent<Image>().color = Color.green;
            }
            else
            {
                Answerbutton2.GetComponent<Image>().color = Color.green;
            }
        }
        gameObject.GetComponent<Button>().interactable = false;
        Answerbutton1.GetComponent<Button>().interactable = false;
        Answerbutton2.GetComponent<Button>().interactable = false;
        Next_button.SetActive(true);
    }
}
