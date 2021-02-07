using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiShmup : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;
    [SerializeField]
    ScoreManager sm;
    [SerializeField]
    ShipController shipm;
    public void TogglePause(bool b)
    {
        pauseMenu.SetActive(b);
        Time.timeScale = b ? 0 : 1;
    }
    public void TogglePause(bool b, float delay)
    {
        StartCoroutine(pause(b, delay));
    }
    private IEnumerator pause(bool b, float delay)
    {
        yield return new WaitForSeconds(delay);
        pauseMenu.SetActive(b);
        Time.timeScale = b ? 0 : 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene("ShipScene");
    }
    public void Restart()
    {
        sm.Zero();
        TogglePause(false);
        shipm.gameObject.SetActive(true);
        shipm.Restore();

    }

}
