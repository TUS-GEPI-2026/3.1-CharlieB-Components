using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    public SpriteRenderer aSR;

    private void Start()
    {
        Debug.Log("yeah that scene is started there now lad");
        Color someColor;
        someColor = new Color(1, 0, 0);
        aSR.color = someColor;
    }

    private void Update()
    {
        // attempted making random colours
        Color randomColor;
        randomColor = new Color(1, 0, 0);
        aSR.color = randomColor;
    }
}

public class the1stscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
