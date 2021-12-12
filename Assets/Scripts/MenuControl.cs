using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public Text Text;
    public Image compucter;
    public void Play()
    {
        SceneManager.LoadScene("Main");
    }
    public void DLC()
    {
        compucter.enabled = true;
        Text.enabled = true;
    }
    public void Autors()
    {
        compucter.enabled = true;
        Text.enabled = true;
        Text.text = "КОТ - Типа умный програмист\n\nЛеруа -  Хентай художник и аниматор\n\nРедис - Коффе в рот пишу кот\n\nДимончик - художник\n\nКулинич - бахнул пива";
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void HideCompucter()
    {
        compucter.enabled = false;
        Text.enabled = false;
    }
}
