using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perekatiPole : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(addForce());
        player = GameObject.Find("BabaYaga");
    }


    IEnumerator addForce()
    {
        yield return new WaitForSeconds(3);
        rb.AddForce(new Vector3(-4, 0, 0), ForceMode2D.Impulse);
        if (Mathf.Abs(transform.position.x - player.transform.position.x) > 100)
            Destroy(gameObject);
        StartCoroutine(addForce());
    }
}
