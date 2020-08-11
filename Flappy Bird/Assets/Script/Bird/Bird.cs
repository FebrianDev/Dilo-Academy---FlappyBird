using UnityEngine;
using UnityEngine.Events;

public class Bird : MonoBehaviour
{
    [SerializeField] private float jumpForce = 100f;
    public static bool isDead;
    [SerializeField] private UnityEvent OnJump, OnDead;

    private Rigidbody2D rigid;
    private Animator anim;

    public static bool gameOver;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1f;
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isDead && Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    public bool IsDead()
    {
        return isDead;
    }

    public void Dead()
    {
        if(!isDead && OnDead != null)
        {
            OnDead.Invoke();
        }
    }
    private void Jump()
    {
        if (rigid)
        {
            rigid.velocity = Vector2.zero;
            if (BtnFire.fire == false)
            {
                rigid.AddForce(new Vector2(0, jumpForce));
            }
        }

        if (OnJump != null)
        {
            OnJump.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Enemy")
        {
            gameOver = true;
            anim.enabled = false;
        }
    }
}
