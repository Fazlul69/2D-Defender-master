using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform[] wayPoints;
    public Transform ExitPoint;
    public int target;
    public float navigationTime;
    public bool isBack;
    public SpriteRenderer sr;
   // public Collider2D checkpointCol;
    // Start is called before the first frame update
    void Start()
    {
        target = 0;
        navigationTime = 0;
        isBack = false;
      //  checkpointCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wayPoints.Length > target)
        {
            navigationTime = Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[target].position, navigationTime);
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {


        
         if (isBack)
         {

             if (col.gameObject.tag == "CheckPoint")
             {
                 target -= 1;
                 sr.flipX = true;
             }
            if (target == 0) {

                isBack = false;
            }
         }
         else {
             if (col.gameObject.tag == "CheckPoint")
             {
                 target += 1;
             }
             if (col.gameObject.tag == "ExitPoint")
             {
                 isBack = true;
             }
         }


    }
}
