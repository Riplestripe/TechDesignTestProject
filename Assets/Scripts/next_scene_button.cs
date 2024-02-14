using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene_button : MonoBehaviour
{
    public void next_scene()
    {
        SceneManager.LoadScene("second_scene");
    }
}
