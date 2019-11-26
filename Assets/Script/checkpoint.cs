using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Collider2D checkpointCol;
    // Start is called before the first frame update
    void Start()
    {
        checkpointCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        checkpointCol.isTrigger = false;
    }
}
