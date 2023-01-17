using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPlayer : MonoBehaviour
{
    Rigidbody2D rb;
    private AudioSource audioSource;
    public AudioClip blair1;
    private Animator animator;
    public GameObject[] houses;

    private CharState1 State
    {
        get { return (CharState1)animator.GetInteger("State"); }
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
            State = CharState1.babaYaga1;
            houses[1].SetActive(false);
            houses[2].SetActive(false);
            houses[3].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 2)
        {
            State = CharState1.babaYaga2;
            houses[0].SetActive(false);
            houses[2].SetActive(false);
            houses[3].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 3)
        {
            State = CharState1.babaYaga3;
            houses[0].SetActive(false);
            houses[1].SetActive(false);
            houses[3].SetActive(false);
        }
        else
        {
            State = CharState1.babaYaga4;
            houses[0].SetActive(false);
            houses[1].SetActive(false);
            houses[2].SetActive(false);
        }

    }

    IEnumerator go()
    {
        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(blair1);
        rb.AddForce(new Vector3(0, 0.001F, 0), ForceMode2D.Impulse);
        StartCoroutine(stop());
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector3(0, 0, 0);
        this.gameObject.GetComponent<PlayerCtrl>().enabled = true;
        this.enabled = false;
    }
}

public enum CharState1
{
    babaYaga1,
    babaYaga2,
    babaYaga3,
    babaYaga4

}
