using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetUpgrade : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Sprite MagnetPaperSprite;
    public Sprite PaperSprite;
    public Sprite MagnetSprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UpgradeAdmin.redTrashCollected >= 5 && UpgradeAdmin.yellowTrashCollected >= 5) 
        {
            SpriteRenderer.sprite = MagnetPaperSprite;
        }
        else if (UpgradeAdmin.redTrashCollected >= 5)
            {
            SpriteRenderer.sprite = MagnetSprite;
           }
        else if(UpgradeAdmin.yellowTrashCollected >= 5)
        {
            SpriteRenderer.sprite = PaperSprite;

        }
    }
}
