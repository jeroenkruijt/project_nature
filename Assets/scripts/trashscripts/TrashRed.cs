using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashRed : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;

    Vector2 playerDirection;

    float timeStamp;

    [SerializeField]
    bool attractToPlayer;
    bool TouchingPlayer;

    public AudioClip Soundeffect;

    void Start()
    {

        player = GameObject.Find("player");
    }
    void Update()
    {
        if (attractToPlayer)
        {
            if (Input.GetKey("f"))
            {
                playerDirection = -(transform.position - player.transform.position).normalized;
                rb.AddForce(new Vector2(playerDirection.x, playerDirection.y) * 10f);
            }

        }
        if (SunkenTrash.TrashisSunken)
        {
            ScoreText.scoreValue -= 100;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(gameObject);
        //ScoreText.scoreValue += 100;

        if (collision.gameObject.CompareTag("binred"))
        {
            UpgradeAdmin.redTrashCollected += 1;
            ScoreText.scoreValue += 100;
            AudioSource.PlayClipAtPoint(Soundeffect, transform.position);
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("bin") && !collision.gameObject.CompareTag("binred"))
        {
            ScoreText.scoreValue -= 100;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("TrashMagnet") && UpgradeAdmin.redTrashCollected >= 5)
        {
            attractToPlayer = true;
        }


    }
}

