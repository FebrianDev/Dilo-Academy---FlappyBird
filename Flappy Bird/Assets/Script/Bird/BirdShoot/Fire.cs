using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bird;

    float birdPosX;
    void Start()
    {
        birdPosX = bird.transform.position.x;
    }

    void Update()
    {
        if (BtnFire.fire && Amount.amount != 0)
        {
            Instantiate(bullet, new Vector2(transform.position.x, bird.transform.position.y), transform.rotation);
            bullet.gameObject.SetActive(true);
            if(Amount.amount > 0)
            {
                Amount.amount -= 1;
                BtnFire.fire = false;
            }   
        }
    }
}
