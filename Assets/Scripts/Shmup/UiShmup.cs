using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiShmup : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;
    [SerializeField]
    

    public void TogglePause(bool b)
    {
        pauseMenu.SetActive(b);
        Time.timeScale = b ? 0 : 1;
    }

    public void Quit()
    {
        //SceneManager.LoadScene(SOMEWHERE)
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
