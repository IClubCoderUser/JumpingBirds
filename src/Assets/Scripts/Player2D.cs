using UnityEngine;

public class Player2D : MonoBehaviour

{
    private Rigidbody2D _physics;
    private bool _isGround;
    private float jump = 5;
    private SpriteRenderer flip;

    public ParticleSystem DamagePS;

    public int health;


    // Start is called before the                                                                                                                                                                              
    void Start()
    {
        _physics = GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            flip.flipX = false;
        }
        if (horizontal < 0)
            flip.flipX = true;

            if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _physics.AddForce(Vector2.up*jump, ForceMode2D.Impulse);


        }
        var vector = new Vector2(x: horizontal, y: _physics.linearVelocity.y);
        _physics.linearVelocity = vector;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    { _isGround = false; }

    [ContextMenu("damage")]
    public void TestDamage()
    {
        Damage(1);
    }

    public void Damage(int Damage)
    {
        health -= Damage;
        DamagePS.Play();
    }

}

