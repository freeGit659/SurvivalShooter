using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSkillCtr : MonoBehaviour
{
    [SerializeField] GameObject skill;
    [SerializeField] Transform skillSpawnTranform;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public  void Spawn()
    {
        GameObject Skill = Instantiate(skill, skillSpawnTranform.transform.position, Quaternion.identity);
    }
}
