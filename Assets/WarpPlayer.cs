using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPlayer : MonoBehaviour
{
    public bool hit;
    public GameObject Warp;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trash"))
        {

            // if (UpgradeAdmin.yellowUpgrade)
            // {
            player.transform.position = new Vector2(Warp.transform.position.x, Warp.transform.position.y);
                hit = true;

          //  }
        }
    }
}
