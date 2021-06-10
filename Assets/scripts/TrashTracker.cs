using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public Text trashTracker;

    // Update is called once per frame
    void Update()
    {
        trashTracker.text = "Red:" + UpgradeAdmin.redTrashCollected.ToString();
        if (UpgradeAdmin.redUpgrade)
        {
            trashTracker.color = new Color(255, 215, 0);
        }
    }
}
