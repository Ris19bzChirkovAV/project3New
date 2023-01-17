using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    private Vector3 startPosition;
    public GameObject player;
    private bool go = true;
    private AudioSource audioSource;
    public AudioClip fir;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.Find("BabaYaga");
        startPosition = transform.position;
    }
    void FixedUpdate()
    {
        if (Mathf.Abs(startPosition.x - transform.position.x) > 1.5F || Mathf.Abs(startPosition.y - transform.position.y) > 1.5F)
            Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (go)
            {
                audioSource.PlayOneShot(fir);
                player.GetComponent<PlayerCtrl>().addHealth(-0.2F);
                go = false;
                StartCoroutine(wait());
            }

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        go = true;

    }

}
