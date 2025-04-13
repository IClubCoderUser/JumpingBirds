using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    public float _health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float Health
    {
        get => _health;
        set
        {
            _health = value;
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Debug.Log("i am die");
    }
}
