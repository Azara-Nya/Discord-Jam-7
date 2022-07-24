using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public Timer Tim;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Animator Andy;

    public void ToMainMenu()
    {
        StartCoroutine(MenuTo());
    }

    public void ToGame()
    {
        StartCoroutine(GameTo());
    }

    void Update()
    {
        text.text = $"Score:{Tim.score}";
    }

    IEnumerator GameTo()
    {
        Tim.health=3;
        Tim.score=0;
        Tim.OffMenu=true;
        Tim.SFX[0].SetActive(false);
        Tim.SFX[1].SetActive(false);
        Tim.SFX[2].SetActive(false);
        Andy.SetBool("StartFade", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Basket");
        Andy.SetBool("StartFade", false);
    }

    IEnumerator MenuTo()
    {
        Andy.SetBool("StartFade", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }

    public void Quiter()
    {
        StartCoroutine(Quiting());
    }

    IEnumerator Quiting()
    {
        Andy.SetBool("StartFade", true);
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
