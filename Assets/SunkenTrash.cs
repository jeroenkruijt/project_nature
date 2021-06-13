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
    bool survived;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (waswaited)
        {

            ScoreText.scoreValue -= 100;
            waswaited = false;
            Destroy(Trash);
        }
    }
   
}

// public IEnumerator SinkTrash(GameObject gobject)
// {
//   yield return new WaitForSeconds(2f);
//   waswaited = true;


//}
//  private void OnCollision2D

