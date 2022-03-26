using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lines : MonoBehaviour
{
    public TextMeshProUGUI textcomp;
    [TextArea(3, 10)]
    public string[] dialogue;
    public float textspeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textcomp.text = string.Empty;
        startdialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void startdialogue()
    {
        index = 0;
        StartCoroutine(typeline());
    }

    IEnumerator typeline()
    {

        foreach (char c in dialogue[index].ToCharArray())
        {
            textcomp.text += c;
            yield return new WaitForSeconds(textspeed);
        }
        
    }
    public void nextdialogue()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            textcomp.text = string.Empty;
            StartCoroutine(typeline());
        }
        else
        {
            startdialogue();
        }

    }
}
