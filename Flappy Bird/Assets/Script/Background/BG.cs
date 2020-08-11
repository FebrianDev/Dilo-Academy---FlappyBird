using UnityEngine;
public class BG: MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;

    public GameObject[] bg;

    private void FixedUpdate()
    {
        for (int i = 0; i < bg.Length; i++)
        {
            
                bg[i].transform.position = Vector2.MoveTowards(bg[i].transform.position, new Vector2(-28f, transform.position.y), speed);

                if (bg[i].transform.position.x == -28f)
                {
                    bg[i].transform.position = new Vector2(15.6f, transform.position.y);
                }
        }
    }
}
