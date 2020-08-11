using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    private float timer, jeda = 3f;
    private GameObject enemy;
    private Bird bird;
    private AudioSource audio;
    [SerializeField] private float speed = 1f;
    void Start()
    {
        bird = GameObject.FindWithTag("Bird").GetComponent<Bird>();
        audio = GetComponent<AudioSource>();
        enemy = GameObject.FindWithTag("Enemy");     
    }
   
    void Update()
    {
        if (!bird.IsDead())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        if (enemy != null)
        {

            timer += Time.deltaTime;
            if (timer > jeda)
            {
                Instantiate(bullet, enemy.transform.position, Quaternion.identity);
                timer = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            audio.PlayOneShot(audio.clip);
            Destroy(gameObject);
        }
    }
}
