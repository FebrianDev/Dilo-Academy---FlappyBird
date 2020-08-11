using UnityEngine;
using UnityEngine.UI;
public class Amount : MonoBehaviour
{
    Text textAmount;
    public static int amount;
    void Start()
    {
        textAmount = GetComponent<Text>();
        amount = 10;
    }
    
    void Update()
    {
        textAmount.text = amount.ToString();    
    }
}
