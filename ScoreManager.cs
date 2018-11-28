using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public int currentScore;
    public int combo;

    public void AddPoint(int amountToAdd)
    {
        currentScore += amountToAdd;
        combo += amountToAdd;
    }


	// Use this for initialization
	void Start () {

        currentScore = 0;
        combo = 0;
        print("im code that works!");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
