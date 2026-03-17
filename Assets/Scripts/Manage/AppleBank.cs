using UnityEngine;
using UnityEngine.UI;

public class AppleBank : MonoBehaviour
{
    [HideInInspector]
    public float appleBank;
    public static AppleBank instance;
    public Text appleTxt;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }
    void Start()
    {
       
    }

    
    void Update()
    {
       
        appleTxt.text = appleBank.ToString();
    }

    public void Collect(float appleCollected)
    {
        appleBank += appleCollected;
        appleTxt.text = appleBank.ToString();
    }
}
