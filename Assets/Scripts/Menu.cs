using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public Timer Tim;
    [SerializeField] private TextMeshProUGUI text;

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }

    public void ToGame()
    {
        Tim.health=3;
        Tim.score=0;
        Tim.OffMenu=true;
        SceneManager.LoadScene("Basket");
    }

    void Update()
    {
        text.text = $"Score:{Tim.score}";
    }
}
