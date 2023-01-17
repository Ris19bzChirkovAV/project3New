using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChanger : MonoBehaviour
{
    public Image[] images;
    void Start()
    {
        if (PlayerPrefs.GetInt("PlayerNumber") == 1)
        {
            images[0].gameObject.SetActive(true);
            images[1].gameObject.SetActive(true);
            images[2].gameObject.SetActive(false);
            images[3].gameObject.SetActive(false);
            images[4].gameObject.SetActive(false);
            images[5].gameObject.SetActive(false);
            images[6].gameObject.SetActive(false);
            images[7].gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 2)
        {

            images[0].gameObject.SetActive(false);
            images[1].gameObject.SetActive(false);
            images[2].gameObject.SetActive(true);
            images[3].gameObject.SetActive(true);
            images[4].gameObject.SetActive(false);
            images[5].gameObject.SetActive(false);
            images[6].gameObject.SetActive(false);
            images[7].gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("PlayerNumber") == 3)
        {
            images[0].gameObject.SetActive(false);
            images[1].gameObject.SetActive(false);
            images[2].gameObject.SetActive(false);
            images[3].gameObject.SetActive(false);
            images[4].gameObject.SetActive(true);
            images[5].gameObject.SetActive(true);
            images[6].gameObject.SetActive(false);
            images[7].gameObject.SetActive(false);
        }
        else
        {
            images[0].gameObject.SetActive(false);
            images[1].gameObject.SetActive(false);
            images[2].gameObject.SetActive(false);
            images[3].gameObject.SetActive(false);
            images[4].gameObject.SetActive(false);
            images[5].gameObject.SetActive(false);
            images[6].gameObject.SetActive(true);
            images[7].gameObject.SetActive(true);

        }
        this.enabled = false;
    }

}
