using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeNotification2 : MonoBehaviour
{
    public Text Notification;
    public bool Notificationisshown;
    public string message;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (UpgradeAdmin.yellowUpgrade == true)
        {
            StartCoroutine(showNotification());
            Notification.text = message;
        }


        if (UpgradeAdmin.yellowUpgrade == true && Notificationisshown == true)
        {
            Destroy(this.gameObject);
        }

    }
    IEnumerator showNotification()
    {
        yield return new WaitForSeconds(3);
        Notificationisshown = true;
    }
}
