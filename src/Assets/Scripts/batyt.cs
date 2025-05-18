using UnityEngine;

public class batyt : MonoBehaviour
{
    public float power = 10f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) ;
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * power , ForceMode2D.Impulse) ;
        }

    }
}

