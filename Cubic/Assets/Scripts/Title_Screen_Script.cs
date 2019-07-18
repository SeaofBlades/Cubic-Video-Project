using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Script : MonoBehaviour
{
    public GameObject first_movie;
    public void Start_game()
    {
        first_movie.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
