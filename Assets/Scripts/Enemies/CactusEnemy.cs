using System.Collections;
using UnityEngine;

public class CactusEnemy : MonoBehaviour
{
    public float speed;
    float waitTime;
    float startWaitingtime = 3f;
    int i;



    public Transform[] points;
    SpriteRenderer sR;
    Vector2 currentPos;
    Animator anim;
    Rigidbody2D rb;

    void Start()
    {
        sR= GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        waitTime = startWaitingtime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitCheck());
       transform.position = Vector2.MoveTowards(transform.position, points[i].transform.position, speed*Time.deltaTime);
        if (Vector2.Distance(transform.position,points[i].transform.position) < 0.02f)
        {
            if (waitTime <= 0)
            {
                if (points[i] != points[points.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = startWaitingtime;

            }
            waitTime -= Time.deltaTime; 
        }
    }

   IEnumerator WaitCheck()
    {
        currentPos = transform.position;
        yield return new WaitForSeconds(0.5f);
        if(transform.position.x > currentPos.x)
        {
            sR.flipX = true;
        }
        else if(transform.position.x < currentPos.x)
        {
            sR.flipX=false;
        }
    }

    
}
