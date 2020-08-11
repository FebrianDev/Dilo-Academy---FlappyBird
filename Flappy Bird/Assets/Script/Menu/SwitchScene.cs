using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public GameObject panel;
    public GameObject canvas;
    
    void Start()
    {
        panel.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _Main();
        }
    }

    public void _Main()
    {
        StartCoroutine(ReadyForSwitchScene());
    }

    IEnumerator ReadyForSwitchScene()
    {
        canvas.SetActive(false);
        panel.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene");
    }
}
