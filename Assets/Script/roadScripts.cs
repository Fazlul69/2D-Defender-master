using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadScripts : MonoBehaviour
{
    public Rigidbody playerRigid;
    public GameObject roadCreate;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //float H = Input.GetAxis("Horizontal");
        playerRigid.velocity = new Vector3(0,0,-2);
    }

    public void OnTriggerEnter(Collision col) {
        if (col.gameObject.tag == "CheckPoint") {

           GameObject newRoadpox = Instantiate(roadCreate);
            newRoadpox.transform.position = roadCreate.po
        }
    }
}
