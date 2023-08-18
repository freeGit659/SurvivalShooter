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
        get { return levelCurrent; }
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
        if (this.levelCurrent < 0) this.levelCurrent = 0;
        if( this.levelCurrent >= this.levelMax) this.levelCurrent = this.levelMax;
    }

    public virtual void UpLevel()
    {
        this.levelCurrent++;
        LevelLimited();
    }
    public virtual void SetLevel(int newLevel)
    {
        this.levelCurrent = newLevel;
        LevelLimited();
    }
}
