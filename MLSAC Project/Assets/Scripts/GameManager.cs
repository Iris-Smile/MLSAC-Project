using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }

    public void UpdateCoinText(int coins)
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}
