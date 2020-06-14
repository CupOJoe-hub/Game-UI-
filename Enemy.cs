using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Stats stats;
    public float Damage = 0.2f;
    
    void Start()
    {   
        stats.TakeDamage();
    }
}
