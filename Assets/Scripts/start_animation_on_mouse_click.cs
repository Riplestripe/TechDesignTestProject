using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_animation_on_mouse_click : MonoBehaviour
{
    private Animator _animation;

    private void Start()
    {
        _animation = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animation.SetTrigger("click");
    }
}
