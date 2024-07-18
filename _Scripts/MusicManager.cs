using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
     private static MusicManager instance;
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
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "the real 1")  // Replace "SpecialScene" with the name of your special scene
        {
            PlayMusic(specialSceneMusic);
        }
        else
        {
            PlayMusic(defaultMusic);
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.Stop();  // Stop the current music
        audioSource.clip = clip;
        audioSource.Play();
    }
}
