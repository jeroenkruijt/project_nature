using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkTrash : MonoBehaviour
{
    public static bool sinkTrash = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sinkTrash)
        {
            ScoreText.scoreValue -= 100;
            Destroy(this.gameObject);
        }
    }
}
