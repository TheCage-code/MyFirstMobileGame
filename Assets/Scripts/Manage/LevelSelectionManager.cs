using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectionManager : MonoBehaviour
{
    int levelIndex;

    public Button[] buttons;
    void Start()
    {
        levelIndex = PlayerPrefs.GetInt("CurrentLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelIndex && i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
    }

    
    void Update()
    {
        
    }
    public void LoadScene(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
