using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Text bronzeCoins;
    public Text silverCoins;
    public Text goldCoins;
    
    public int coinType;
    
    public int bronze = 0;
    public int silver = 0;
    public int gold = 0;

    public Enemy enemy;

    public Slider Health;
    public float health = 1;
    
    public Slider Armor;
    public float armor = 1;
    
    public Slider Mana;
    public float mana = 1;
    
    void Start()
    {
        Health.value = health;
        Armor.value = armor;
        Mana.value = mana;
        
        bronzeCoins.text = bronze.ToString();
        silverCoins.text = silver.ToString();
        goldCoins.text = gold.ToString();
    }
    
    void Update()
    {
        AddCoins();
    }
    
    void CoinUpdate()
    {
        switch(coinType)
        {
            case 0:
                bronze += Random.Range(0, 4);
                bronzeCoins.text = bronze.ToString();
                break;
                
            case 1:
                silver += Random.Range(0, 4);
                silverCoins.text = silver.ToString();
                break;
            case 2:
                gold += Random.Range(0, 4);
                goldCoins.text = gold.ToString();
                break;
        }
    }
    
    public void TakeDamage()
    {
        if(armor < 0)
        {
            health -= enemy.Damage;
            Health.value = health;
        }else
        {
            armor -= enemy.Damage;
            Armor.value = armor;
        }
       
    }
    public void GainLife()
    {
        if(health > 0.99f)
        {
            armor += 0.2f;
            Armor.value = armor;
        }else
        {
            health += 0.2f;
            Health.value = health;
        }
    }
    
    public void AddCoins()
    {
        coinType = Random.Range(0, 3);
        CoinUpdate();
    }
    
    
}
