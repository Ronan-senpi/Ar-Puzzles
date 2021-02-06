using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LaunchShmup : MonoBehaviour
{
    public void LaunchShmupScene()
    {
        SceneManager.LoadScene("Shmup");
    }
}
