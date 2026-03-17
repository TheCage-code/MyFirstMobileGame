using UnityEngine;

public class SawTrap : MonoBehaviour
{
    public float speed;
    public Transform[] points;
    int i;
    float waitTime;
    float waitTimeToMove = 2f;

    void Start()
    {
        //transform.position = points[i].transform.position;
        waitTime = waitTimeToMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].transform.position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }
        Move();
        
    }

    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,points[i].transform.position,speed*Time.deltaTime);
    }
}
