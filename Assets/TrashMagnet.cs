using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMagnet : MonoBehaviour
{

    public GameObject Magnet;
    public GameObject Player;

    // Start is called before the first frame update
    void Update()
    {
        Magnet.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }
}
