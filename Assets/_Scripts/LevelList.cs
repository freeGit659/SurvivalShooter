using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelList : MonoBehaviour
{
    public LevelCtrl[] levels;
    private void Awake()
    {
        
    }
    void Start()
    {
        levels = GetComponentsInChildren<LevelCtrl>();
    }
    void Update()
    {
        
    }
    private void LoadLevelList()
    {
        
    }
}

