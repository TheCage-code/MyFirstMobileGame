using UnityEngine;

public class Cannonenemy : MonoBehaviour
{
    private float waitTime;
    public float waitTimeToAttack;



    public Transform attackPoint;
    public GameObject bullet;
    Animator anim;
    

    void Start()
    {
        anim= GetComponent<Animator>();
        waitTime = waitTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime <= 0)
        {
            waitTime = waitTimeToAttack;
            anim.SetTrigger("Attack");
            Invoke("LaunchAttack", 0.3f);
        }
        else
        {
            waitTime-= Time.deltaTime;
        }
    }

    public void LaunchAttack()
    {
        Instantiate(bullet, attackPoint.position, attackPoint.rotation);
    }
}
