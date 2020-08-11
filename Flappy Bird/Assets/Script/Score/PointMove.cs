using UnityEngine;

public class PointMove : MonoBehaviour
{

    [SerializeField] private Bird bird;
    [SerializeField] private float speed = 1f;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bird")
        {
            Score.score += 1;
            audio.PlayOneShot(audio.clip);
        }
    }
}
