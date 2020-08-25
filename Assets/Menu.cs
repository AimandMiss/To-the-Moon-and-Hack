using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void winner()
    {
        SceneManager.LoadScene("Win");
    }

    public void instt()
    {
        SceneManager.LoadScene("Inst");
    }

    public void Die(Collider2D other)
    {
        if(other.CompareTag("Player"))
            SceneManager.LoadScene("Game Over");
    }
}
