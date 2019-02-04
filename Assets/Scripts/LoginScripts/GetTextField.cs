using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetTextField : MonoBehaviour
{
    public Text userfield;
    public GameObject passfield;
    public GameObject textfield;

    public void validator()
    {
        if(userfield.gameObject.GetComponent<Text>().text=="cachecake" && passfield.gameObject.GetComponent<InputField>().text == "123")
        {
            PlayerPrefs.SetInt("user", 0);
            SceneManager.LoadScene("Main Menu");
        }

        else if (userfield.gameObject.GetComponent<Text>().text == "hacksmu404" && passfield.gameObject.GetComponent<InputField>().text == "123")
        {
            PlayerPrefs.SetInt("user", 1);
            SceneManager.LoadScene("Main Menu");
        }

        else
        {
            textfield.SetActive(true);
        }
        



    }

    // Start is called before the first frame update
    void Start()
    {
                    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
