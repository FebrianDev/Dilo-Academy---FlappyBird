using UnityEngine;

public class BtnFire : MonoBehaviour
{
    public static bool fire;

    private void Start()
    {
        fire = false;
    }

    public void Fire()
    {
        if (Amount.amount != 0)
            fire = true;
        else fire = false;
    }
}
