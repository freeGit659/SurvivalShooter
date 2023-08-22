using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    [SerializeField] LevelCtrl level;
    public string infomationText;
    public Sprite sprite;
    public float moveSpeed;
    public float fireSpeed;
    public float fireDamage;
    public int maxHP;
    public int currentHP;
}
