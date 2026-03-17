using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveDamage : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            //Destroy(collision.gameObject);
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            AppleBank.instance.appleBank = 0;
        }
    }
}
