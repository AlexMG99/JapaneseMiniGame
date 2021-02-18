using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hiragana : MonoBehaviour
{
    [Tooltip("Enemy Text")]
    TextMesh characterText;

    // Start is called before the first frame update
    void Start()
    {
        characterText = GetComponentInChildren<TextMesh>();
        char c = System.Convert.ToChar(12360);
        //double num = System.Convert.ToInt16('い'); // あ 12354 い 12356 う 12358 え 12360 お 12362 に 12395 
        //Debug.Log(num);

        characterText.text = c.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
