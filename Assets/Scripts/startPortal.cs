using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPortal : MonoBehaviour
{
    Rigidbody2D rb;
    private AudioSource audioSource;
    public AudioClip blair1;
    private Animator animator;
    public GameObject portal;

    private CharState2 State
    {
        get { return (CharState2)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(go());
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("PlayerNumber") == 1)
        {
            State = CharState2.babaYaga1;

        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 2)
        {
            State = CharState2.babaYaga2;

        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 3)
        {
            State = CharState2.babaYaga3;

        }
        else
        {
            State = CharState2.babaYaga4;
        }

    }

    IEnumerator go()
    {
        yield return new WaitForSeconds(0);
        audioSource.PlayOneShot(blair1);
        rb.AddForce(new Vector3(0.001F, 0, 0), ForceMode2D.Impulse);
        StartCoroutine(stop());
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector3(0, 0, 0);
        portal.GetComponent<CircleCollider2D>().enabled = true;
        this.gameObject.GetComponent<PlayerCtrl>().enabled = true;
        this.enabled = false;
    }
}

public enum CharState2
{
    babaYaga1,
    babaYaga2,
    babaYaga3,
    babaYaga4

}
