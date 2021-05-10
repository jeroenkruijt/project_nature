using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPurple : MonoBehaviour
{
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
        //Destroy(gameObject);
        //ScoreText.scoreValue += 100;

        if (collision.gameObject.CompareTag("binpurple"))
        {
            ScoreText.scoreValue += 100;
            Destroy(gameObject);
        }
        else if (!collision.gameObject.CompareTag("binpurple"))
        {
            ScoreText.scoreValue -= 100;
            Destroy(gameObject);
        }
    }
}
