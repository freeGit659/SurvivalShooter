using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int score;
    public int m_score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_score= score;
    }
}
