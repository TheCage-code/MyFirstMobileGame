using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    private float waitTime;
    private float waitTimeToAttack = 2f;
    public float speed;
    public int startingPoint;
    public Transform[] points;
    public GameObject bullet;
    public Transform attackPoint;
    Animator anim;
    
    
    int i;
    void Start()
    {
        anim = GetComponent<Animator>();
        transform.position = points[startingPoint].position;
        waitTime = waitTimeToAttack;
    }

    
    void Update()
    {
        Movement();
        if (waitTime <= 0)
        {
            waitTime= waitTimeToAttack;
            Invoke("Attack", 0.3f);
            
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
        
    }

    public void Movement()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if(i == points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position,speed*Time.deltaTime);
    }
    public void Attack()
    {
        Instantiate(bullet, attackPoint.position, attackPoint.rotation);
    }
}
