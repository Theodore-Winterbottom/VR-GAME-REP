using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonScript : MonoBehaviour
{
    public Animation animator;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            animator.Play();
        }
    }
}
