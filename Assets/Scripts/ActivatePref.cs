using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePref : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("user")==0)
        {
            obj2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("user") == 1)
        {
            obj1.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
