using UnityEngine;

public class AmountAdd : MonoBehaviour
{
    public static int amount = 1;

    [SerializeField] private float speed = 1f;

    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigid.velocity = Vector3.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            if (Amount.amount < 10)
            {
                Amount.amount += amount;
            }
            Destroy(gameObject);
        }
    }
}
