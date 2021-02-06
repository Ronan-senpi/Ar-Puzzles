using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{

    [SerializeField]
    protected string name;
    [SerializeField]
    protected AudioClip clip;
    [Range(0, 1)]
    [SerializeField]
    protected float volume;
    [Range(0.1f, 1)]
    [SerializeField]
    protected float pitch;
    //[SerializeField]
    //protected bool playOnAwake;
    [SerializeField]
    protected bool loop;
    public AudioSource Source { get; set; }

    public bool Loop
    {
        get { return loop; }
        set { if (value != loop) loop = value; }
    }
    public string Name
    {
        get { return name; }
        set { if (value != name) name = value; }
    }
    public AudioClip Clip
    {
        get { return clip; }
        set { if (value != clip) clip = value; }
    }
    public float Volume
    {
        get { return volume; }
        set { if (value != volume) volume = value; }
    }
    public float Pitch
    {
        get { return pitch; }
        set { if (value != pitch) pitch = value; }
    }
    //public bool PlayOnAwake
    //{
    //    get { return playOnAwake; }
    //    set { if (value != playOnAwake) playOnAwake = value; }
    //}

}

