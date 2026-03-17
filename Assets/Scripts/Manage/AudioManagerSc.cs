using UnityEngine;

public class AudioManagerSc : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenSound()
    {
        audioSource.UnPause();
    }
    public void MuteSound()
    {
        audioSource.Pause();
    }
}
