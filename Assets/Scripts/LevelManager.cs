using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private DataManager dataManager;
    protected int levelCurrent;
    [SerializeField] protected int levelMax;

    public int LevelCurrent
    {
        get { return this.levelCurrent; }
    }

    void Start()
    {
        dataManager = GetComponentInParent<DataManager>();
    }

    void Update()
    {
        
    }

    protected virtual void LevelLimited()
    {
        if (levelCurrent < 0) levelCurrent = 0;
        if( levelCurrent >= levelMax) levelCurrent = levelMax;
    }

    public virtual void UpLevel()
    {
        levelCurrent++;
        LevelLimited();
    }
    public virtual void SetLevel(int newLevel)
    {
        levelCurrent = newLevel;
        LevelLimited();
    }
}
