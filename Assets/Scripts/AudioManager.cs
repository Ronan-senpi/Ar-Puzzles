﻿
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; set; }
    [SerializeField]
    protected Sound[] sounds;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;

            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            //s.Source.playOnAwake = s.PlayOnAwake;
            s.Source.loop = s.Loop;
        }
    }

    private void Start()
    {
        string scene = SceneManager.GetActiveScene().name;
        if(scene == "ShipScene")
            Play("ThemePuzzle");
        else if(scene == "Shmup")
            Play("ThemeShmup");
    }

    public void Play(string name)
    {
        Sound s = sounds.FirstOrDefault(x => x.Name == name);
        if (s != null)
            s.Source.Play();

    }
}
