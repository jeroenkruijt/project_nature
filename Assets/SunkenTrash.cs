using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class SunkenTrash : MonoBehaviour
{
    [SerializeField] TilemapCollider2D waterborder;
    [SerializeField] bool NoWaterBorder = false;
    public static bool TrashisSunken = false;
    public GameObject Trash;
    public bool waswaited;
    bool TrashisinWater;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
    }
    public IEnumerator SinkTrash()
    {
        yield return new WaitForSeconds(2f);
        waswaited = true;
        Debug.Log("Coroutine Started");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trash"))
        {
         waswaited = false;
        GameObject Trash = collision.gameObject;
        StartCoroutine(SinkTrash());
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
            if (waswaited)
            {
                ScoreText.scoreValue -= 100;
                waswaited = false;
                Destroy(collision.gameObject);
            }
        }
       

    }
    




