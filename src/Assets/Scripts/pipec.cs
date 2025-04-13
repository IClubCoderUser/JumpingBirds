using UnityEngine;

public class pipec : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        var t = Vector3.Distance(transform.position, player.transform.position);
        if (t>=1)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed);
        }
    }
}

