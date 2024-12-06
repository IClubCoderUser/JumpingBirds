using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetBool("Open", !_animator.GetBool("Open"));
        }
    }
}
