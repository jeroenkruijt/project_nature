using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashCan : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(gameObject);
        //ScoreText.scoreValue += 100;

        if (collision.gameObject.CompareTag("binred"))
        {
            ScoreText.scoreValue -= 100;
            Destroy(gameObject);
        }
    }
       
}
