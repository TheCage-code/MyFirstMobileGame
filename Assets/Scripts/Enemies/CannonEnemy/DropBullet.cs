using UnityEngine;

public class DropBullet : MonoBehaviour
{
    
    public float speed;
    public float lifeTime;
    



    void Start()
    {
        Destroy(gameObject, lifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
            
            transform.Translate(Vector2.down * speed * Time.deltaTime);

        
       

       
        
        
    }
}
