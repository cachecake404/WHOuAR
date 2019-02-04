using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenImage : MonoBehaviour
{
    public GameObject img1;
    public GameObject img2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("user")==0)
        {
            img1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("user") == 1)
        {
            img2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
