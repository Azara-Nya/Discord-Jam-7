using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Timer Tim;

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }

    public void ToGame()
    {
        Tim.health=3;
        Tim.OffMenu=true;
        SceneManager.LoadScene("Basket");
    }
}
