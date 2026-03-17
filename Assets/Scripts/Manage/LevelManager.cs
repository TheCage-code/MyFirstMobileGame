using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private float isComplete = 5;
    public Text isCompleteTxt;
    public static LevelManager instance;
    Animator anim;
    public GameObject levelTrans;
    LevelSelect selection;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
        selection = GetComponent<LevelSelect>();    
    }

    
    void Update()
    {
        isCompleteTxt.text = isComplete.ToString();
        if (AppleBank.instance.appleBank == isComplete)
        {
            
            levelTrans.SetActive(true);
            AppleBank.instance.appleBank = 0;
           
            StartCoroutine(Waiting());
            
            StartCoroutine(WaitingTwo());
            selection.GetLevelIndex();


            //Invoke("ChangeLevel", 1.2f);
        }
    }
    void ChangeLevel()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1.5f);
        ChangeLevel();
        
    }
    IEnumerator WaitingTwo()
    {
        yield return new WaitForSeconds(1.7f);
        levelTrans.SetActive(false);

    }
}
