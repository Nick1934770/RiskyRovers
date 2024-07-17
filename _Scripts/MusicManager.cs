
using UnityEngine;

public class MusicManager : MonoBehaviour
{
     public static MusicManager instance;
    private AudioSource audioSource;

    public AudioClip defaultMusic;
    public AudioClip specialSceneMusic;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            PlayMusic(defaultMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (audioSource.clip != clip)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if (scene.name == "SpecialScene")  // Replace "SpecialScene" with the name of your special scene
        {
            PlayMusic(specialSceneMusic);
        }
        else
        {
            PlayMusic(defaultMusic);
        }
    }
}
