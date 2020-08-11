using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Bird bird;
    [SerializeField] private float speed = 1f;

    private void Start()
    {
        bird = GameObject.FindWithTag("Bird").GetComponent<Bird>();
    }

    void Update()
    {
        if (!bird.IsDead())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Bird")
        {
            bird.Dead();
        }
    }
}
