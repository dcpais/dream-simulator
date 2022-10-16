using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class captionManager : MonoBehaviour
{

    public TextMeshProUGUI textBox;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(startCaptionSequence("OogedyBoogedy", 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator startCaptionSequence(string text, float duration)
    {
        yield return new WaitForSeconds(4);
        float fadeTime = 0.5f; 
        float elapsed = 0.0f;
        textBox.text = text;
        textBox.color = new Color(1, 1, 1, 0);

        while (elapsed < duration)
        {
            if (elapsed <= fadeTime)
            {
                textBox.color = new Color(1, 1, 1, elapsed / fadeTime);
                Debug.Log(textBox.color.ToString());
            }
            else if (elapsed > fadeTime && elapsed < duration - fadeTime) 
            {
                textBox.color = new Color(1, 1, 1, 1);
            }
            else if (elapsed > duration - fadeTime)
            {
                textBox.color = new Color(1, 1, 1, 1 - ((elapsed - (duration - fadeTime)) / fadeTime));
            }
            elapsed += Time.deltaTime;

            yield return null;
        }
        textBox.color = new Color(1, 1, 1, 0);

    }
}
