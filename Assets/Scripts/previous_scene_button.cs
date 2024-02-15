using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class previous_scene_button : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("first_scene");
    }
}
