using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gol1 : MonoBehaviour
{
    public TextMeshProUGUI texto_gols;
    public int gols = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bola"))
        {
            gols += 1; 
            texto_gols.text = gols.ToString();

        }


    }
}
