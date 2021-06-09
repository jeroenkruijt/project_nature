using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMagnet : MonoBehaviour
{
    public GameObject player;
   

    // Start is called before the first frame update
    void Update()
    {
        transform.position = player.transform.position;
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }
}
