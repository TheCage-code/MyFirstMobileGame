using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerRespawn : MonoBehaviour
{
    Animator anim;

    public GameObject[] hearts;
    int life;
    void Start()
    {
        anim = GetComponent<Animator>();
        life = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HeartCheck()
    {
        if (life < 0)
        {
            anim.SetTrigger("TakeHit");
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (life < 1)
        {
            anim.SetTrigger("TakeHit");
            Destroy(hearts[1].gameObject);
        }
        else if (life < 2)
        {
            anim.SetTrigger("TakeHit");
            Destroy(hearts[2].gameObject);
        }
    }
    public void PlayerDamage()
    {
        // anim.SetTrigger("TakeHit");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        life--;
        HeartCheck();
    }

}
