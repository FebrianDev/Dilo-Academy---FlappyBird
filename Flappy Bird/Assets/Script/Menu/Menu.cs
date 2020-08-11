using UnityEngine;
public class Menu : MonoBehaviour
{
    public GameObject menu, panel,panel2;
    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        if (Bird.gameOver)
        {
            menu.SetActive(true);
            panel.SetActive(false);
            panel2.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
