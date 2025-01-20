using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger3 : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
        }
    }
}
