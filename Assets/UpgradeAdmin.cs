using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAdmin : MonoBehaviour
{
    [SerializeField] public static int redTrashCollected = 0;
    public static int yellowTrashCollected = 0;
    public static int blueTrashCollected = 0;
    public static int greenTrashCollected = 0;
    public static bool redUpgrade;
    [SerializeField] public static bool yellowUpgrade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(redTrashCollected >= 5)
        {
            redUpgrade = true;

        }

        if (yellowTrashCollected >= 5)
        {
            yellowUpgrade = true;

        }
    }

}
