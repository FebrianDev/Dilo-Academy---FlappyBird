using UnityEngine;

public class BulletEnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rigid;
    private Bird bird;

    void Start()
    {
        bird = GameObject.FindWithTag("Bird").GetComponent<Bird>();
        rigid = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

    void Update()
    {
        rigid.velocity = Vector3.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            Bird.gameOver = true;
            bird.Dead();
            Destroy(gameObject);
        }
    }
}
