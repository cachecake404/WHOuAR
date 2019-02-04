using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BlockSpawner : MonoBehaviour 
{
    // Start is called before the first frame update
    public float spacing = 1f;
    public GameObject SpawnMe;
    public GameObject TextMe;
    float curHeight;
    float curSide;
    int probSolv =0;
    int timMang =0;
    int DatStru = 0;
    float curDepth;
    //List<GameObject> generatedStuff = new List<GameObject>();
    void Start()
    {
        curHeight = this.gameObject.GetComponent<Transform>().position.y;
        curSide = this.gameObject.GetComponent<Transform>().position.x;
        curDepth = this.gameObject.GetComponent<Transform>().position.z;
        if (PlayerPrefs.GetInt("user")==0)
        {
            probSolv = (int) PlayerPrefs.GetFloat("ProblemSolving");
            timMang = (int)PlayerPrefs.GetFloat("Competetive") ;
            DatStru = (int)PlayerPrefs.GetFloat("Persistant") ;
            createBars(probSolv, "Probelm Solving");
            createBars(timMang, "Competetiveness");
            createBars(DatStru, "Persistance");

        }
        if (PlayerPrefs.GetInt("user") == 1)
        {
            probSolv = 4;
            timMang = 4;
            DatStru = 4;
            createBars(probSolv, "Probelm Solving");
            createBars(timMang, "Time Management");
            createBars(DatStru, "Data Structures");

        }



    }

    public void createBars(int NumberOfObjects,string text)
    {
        //Debug.Log("I was called!");
        curHeight += spacing;
        for (int i = 0; i < NumberOfObjects; i++)
        {
            Debug.Log("Going to make stuff now");
            GameObject ob = Instantiate(SpawnMe);
            ob.transform.position = new Vector3(curSide, curHeight,curDepth);
            this.gameObject.GetComponentInParent<EventHandler>().generatedStuff.Add(ob);
            curHeight += spacing;
        }
        GameObject nob = Instantiate(TextMe);
        nob.gameObject.GetComponent<VTextInterface>().RenderText = text;
        nob.transform.position = new Vector3(curSide, curHeight, curDepth);
        this.gameObject.GetComponentInParent<EventHandler>().generatedStuff.Add(nob);
        curHeight = 0f;
        curSide += 0.05f;
        curDepth += 0.1f;
        for (int i = 0; i < this.gameObject.GetComponentInParent<EventHandler>().generatedStuff.Count; i++)
        {
            this.gameObject.GetComponentInParent<EventHandler>().generatedStuff[i].SetActive(false);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
