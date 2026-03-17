using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MaınMenuManager : MonoBehaviour
{
    public GameObject panel;
    public AudioSource audioGenerator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Settings()
    {
        panel.GetComponent<Animator>().SetTrigger("Pop");
        panel.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Quit()
    {
        Application.Quit(); 
    }
    public void PressSound()
    {
        audioGenerator.Play();
    }
    
}
