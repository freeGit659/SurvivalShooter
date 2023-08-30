using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingManager : MonoBehaviour
{
    public DataManager dataManager;
    public int score;
    void Start()
    {
        
    }

    
    void Update()
    {
        DataManager.score = this.score;
    }
}
