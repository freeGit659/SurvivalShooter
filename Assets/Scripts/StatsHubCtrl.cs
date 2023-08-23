using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsHubCtrl : MonoBehaviour
{
    [SerializeField] Text fireDamageText;
    [SerializeField] Text fireSpeedText;
    [SerializeField] Text moveSpeedText;
    [SerializeField] StatsCtrl statsCtrl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireDamageText.text = statsCtrl.fireDamage.ToString();
        fireSpeedText.text = statsCtrl.fireSpeed.ToString();
        moveSpeedText.text = statsCtrl.moveSpeed.ToString();
    }
}
