using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    Collider2D coll;
    Animator anim;
    SpriteRenderer sR;
    public GameObject deadEffect;
    public int lifes = 1;
    public int jumpForce;
    void Start()
    {
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = (Vector2.up * jumpForce);
            HealthReduce();
            CheckLife();
        }
    }
    public void HealthReduce()
    {
        lifes--;
        anim.Play("TakeHit");
    }
    public void CheckLife()
    {
        if (lifes == 0)
        {
            deadEffect.SetActive(true);
            sR.enabled = false;
            Invoke("EnemyDie", 0.2f);
        }
    }
    public void EnemyDie()
    {
        Destroy(gameObject);
        
    }
}
