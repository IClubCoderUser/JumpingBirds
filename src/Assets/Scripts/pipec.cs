using UnityEngine;

public class pipec : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;
    public float _distanse = 1f;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (player == null)
        {
            Debug.Log($"Ты не выбрал игрока, плохой!!!. {gameObject.name}");
            return;
        }


        var dir = player.transform.position - transform.position;
        if (dir.magnitude<=_distanse)
        {
            transform.position += dir * Time.fixedDeltaTime * speed;
        }
    }
}

