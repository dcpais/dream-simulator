using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class introDialogue : MonoBehaviour
{

    public IEnumerator current = null;
    public TextMeshProUGUI textBox;


    public void Start()
    {
        StartCoroutine(dialogue());
    }

    public IEnumerator dialogue() 
    {
        StartCoroutine(startCaptionSequence(
            "*Yawn* I'm so tired. All the stuff on TV is so boring",
            6
        ));

        yield return new WaitForSeconds(10);
        StartCoroutine(startCaptionSequence(
            "I should probably go to sleep... the TV is even telling me to",
            6
        ));

        yield return new WaitForSeconds(10);
        StartCoroutine(startCaptionSequence(
            "Whats the scientist on the TV saying about bad sleep? I guess i should probably get some more",
            6
        ));

        yield return new WaitForSeconds(8);
        StartCoroutine(startCaptionSequence(
            "I have been losing sleep lately.. It has caused some bad dreams. I just hope they don't get worse.",
            4
        ));

        yield return null;
    }


    public IEnumerator startCaptionSequence(string text, float duration)
    {
        if (current != null)
        {
            StopCoroutine(current);

            current = null;
        }
        float fadeTime = 0.5f;
        float elapsed = 0.0f;
        textBox.text = text;
        textBox.color = new Color(1, 1, 1, 0);

        while (elapsed < duration)
        {
            if (elapsed <= fadeTime)
            {
                textBox.color = new Color(1, 1, 1, elapsed / fadeTime);
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
