using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {


    public GameObject gYourCharacter;
    public GameObject gCharacterFear;
    public GameObject gEncounter;
    public GameObject gPuzzle;
    public GameObject gDeath;

    //List<GameObject> l_CharObjects;

    List<GameObject> l_AngeloObjects;
    List<GameObject> l_JoeObjects;
    List<GameObject> l_ManuelObjects;

    public GameObject Swiper;
    ScrollSnapRect _scrollSnapRect;

    
	// Use this for initialization
	void Start () {
        _scrollSnapRect = Swiper.GetComponent<ScrollSnapRect>();

        l_AngeloObjects = new List<GameObject>();
        l_JoeObjects = new List<GameObject>();
        l_ManuelObjects = new List<GameObject>();

        Load_objectlist();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void SelectCharacter(string charTag) 
    {
        bool isAngelo   = false;
        bool isJoe      = false;
        bool isManuel   = false;
        if (charTag == "Angelo")
            isAngelo = true;
        else if (charTag == "Joe")
            isJoe = true;
        else if (charTag == "Manuel")
            isManuel = true;
        else
            Debug.Assert(true, "CharSelect button problem!");

        for (int i = 0; i < l_AngeloObjects.Count; i++)
        {
            l_AngeloObjects[i].SetActive(isAngelo);
        }
        for (int i = 0; i < l_JoeObjects.Count; i++)
        {
            l_JoeObjects[i].SetActive(isJoe);
        }
        for (int i = 0; i < l_JoeObjects.Count; i++)
        {
            l_ManuelObjects[i].SetActive(isManuel);
        }

        _scrollSnapRect.SetScrollRectComponent_enabled(true);
    }


    void Load_objectlist()
    {
        Debug.Log(gYourCharacter.transform.childCount);
        Debug.Log(gYourCharacter.transform.GetChild(0).gameObject);
        for (int i = 0; i < gYourCharacter.transform.childCount; i++)
        {
            if(gYourCharacter.transform.GetChild(i).gameObject.tag == "Angelo")
            {
                l_AngeloObjects.Add(gYourCharacter.transform.GetChild(i).gameObject);
            }
            else if( gYourCharacter.transform.GetChild(i).gameObject.tag == "Joe" )
            {
                l_JoeObjects.Add(gYourCharacter.transform.GetChild(i).gameObject);
            }
            else if( gYourCharacter.transform.GetChild(i).gameObject.tag == "Manuel" )
            {
                l_ManuelObjects.Add(gYourCharacter.transform.GetChild(i).gameObject);
            }
        }

        for (int i = 0; i < gCharacterFear.transform.childCount; i++)
        {
            if (gCharacterFear.transform.GetChild(i).gameObject.tag == "Angelo")
                l_AngeloObjects.Add(gCharacterFear.transform.GetChild(i).gameObject);
            else if (gYourCharacter.transform.GetChild(i).gameObject.tag == "Joe")
                l_JoeObjects.Add(gCharacterFear.transform.GetChild(i).gameObject);
            else if (gYourCharacter.transform.GetChild(i).gameObject.tag == "Manuel")
                l_ManuelObjects.Add(gCharacterFear.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < gEncounter.transform.childCount; i++)
        {
            if (gEncounter.transform.GetChild(i).gameObject.tag == "Angelo")
                l_AngeloObjects.Add(gEncounter.transform.GetChild(i).gameObject);
            else if (gEncounter.transform.GetChild(i).gameObject.tag == "Joe")
                l_JoeObjects.Add(gEncounter.transform.GetChild(i).gameObject);
            else if (gEncounter.transform.GetChild(i).gameObject.tag == "Manuel")
                l_ManuelObjects.Add(gEncounter.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < gPuzzle.transform.childCount; i++)
        {
            if (gPuzzle.transform.GetChild(i).gameObject.tag == "Angelo")
                l_AngeloObjects.Add(gPuzzle.transform.GetChild(i).gameObject);
            else if (gPuzzle.transform.GetChild(i).gameObject.tag == "Joe")
                l_JoeObjects.Add(gPuzzle.transform.GetChild(i).gameObject);
            else if (gPuzzle.transform.GetChild(i).gameObject.tag == "Manuel")
                l_ManuelObjects.Add(gPuzzle.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < gDeath.transform.childCount; i++)
        {
            if (gDeath.transform.GetChild(i).gameObject.tag == "Angelo")
                l_AngeloObjects.Add(gDeath.transform.GetChild(i).gameObject);
            else if (gDeath.transform.GetChild(i).gameObject.tag == "Joe")
                l_JoeObjects.Add(gDeath.transform.GetChild(i).gameObject);
            else if (gDeath.transform.GetChild(i).gameObject.tag == "Manuel")
                l_ManuelObjects.Add(gDeath.transform.GetChild(i).gameObject);
        }
    }
}
