using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SunkenTrash : MonoBehaviour
{
    [SerializeField] TilemapCollider2D waterborder;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("trash"))
        {
            waterborder.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
