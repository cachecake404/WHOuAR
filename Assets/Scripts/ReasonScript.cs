using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReasonScript : MonoBehaviour
{
    public GameObject txt;
    // Start is called before the first frame update
    public int x = 0;
    void Start()
    {
        if(x==0)
        {
            txt.GetComponent<TextMeshProUGUI>().text = "Problem Solving: \n\n" + PlayerPrefs.GetString("ProblemReason");
        }
        if (x == 1)
        {
            txt.GetComponent<TextMeshProUGUI>().text = "Competetiveness: \n\n" + PlayerPrefs.GetString("CompReason");
        }
        if (x == 2)
        {
            txt.GetComponent<TextMeshProUGUI>().text = "Persistance: \n\n" + PlayerPrefs.GetString("PersReason");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
