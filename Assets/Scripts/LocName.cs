using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocName : MonoBehaviour
{
    private bool end = false;
    public Text text;
    public float w = 1.0F;
    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(go());
    }

    // Update is called once per frame
    void Update()
    {
        if(end)
        {
            text.color = new Vector4(1, 1, 1, w);
            w -= 0.01F;
            if (w <= 0.02F)
            {
                this.gameObject.SetActive(false);
                //this.enabled = false;
            }
        }
    }

    IEnumerator go()
    {
        yield return new WaitForSeconds(5);
        end = true;

    }
}
