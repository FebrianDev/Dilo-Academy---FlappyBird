using UnityEngine;
public class Ground : MonoBehaviour
{
    [SerializeField] private Bird bird;
    [SerializeField] private float speed = 0.02f;

    public GameObject[] ground;

    private void FixedUpdate()
    {
        for (int i = 0; i < ground.Length; i++)
        {
            if (!bird.IsDead())
            {
                ground[i].transform.position = Vector2.MoveTowards(ground[i].transform.position, new Vector2(-17.2f, transform.position.y), speed);

                if (ground[i].transform.position.x == -17.2f)
                {
                    ground[i].transform.position = new Vector2(20f, transform.position.y);
                }
            }
            else
            {
                ground[i].transform.position = new Vector2(ground[i].transform.position.x, ground[i].transform.position.y);
            }
        }
    }
}
