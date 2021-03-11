using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float score;
    public Text scoreOutput;

    public AudioSource sadCat;
    public AudioSource cat;
    public AudioSource gangstaCat;

    public GameObject gangstaGlasses;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreOutput.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score += 10;
        cat.Play();
    }

    public void resetScore()
    {
        score = 0;
        gangstaGlasses.SetActive(false);
        sadCat.Play();
    }

    public void newGangstaCat()
    {
        gangstaGlasses.SetActive(true);
        score = 0;
        gangstaCat.Play();
    }
    
}
