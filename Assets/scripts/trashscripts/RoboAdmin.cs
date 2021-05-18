using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboAdmin : MonoBehaviour
{
    public static int rTrashcollected;

    void Update()
    {
        Debug.Log("Red Trash collected:" +rTrashcollected);
    }

}