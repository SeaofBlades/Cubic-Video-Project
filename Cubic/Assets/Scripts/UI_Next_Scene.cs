using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Next_Scene : MonoBehaviour
{
    public GameObject next_movie;
    public void Start_game()
    {
        next_movie.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
