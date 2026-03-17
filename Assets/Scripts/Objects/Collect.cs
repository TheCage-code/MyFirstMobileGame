using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public float amount;
    public AudioSource audioGenerator;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AppleBank.instance.Collect(amount);


            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject,0.4f);
            audioGenerator.Play();
        }
    }
}
