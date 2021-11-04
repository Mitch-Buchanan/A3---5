using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHealer : MonoBehaviour
{
    [SerializeField] private int healthHealer = 900; 
    [SerializeField] private int currentHealth;  
    private int i = 0; private int bossTotDamage; 

    private HealthBar _HealthBar; 

    private void Awake () {
    	this._HealthBar = this.GetComponentInChildren<HealthBar>();

    	this.currentHealth = this.healthHealer;
    	this.UpdateHealthBar();
    }

    public int bossDamage (){return Random.Range(5, 20);}
   
    private void Update (){ 
    	i++; 
    	if (i % 100 == 0){
    		int bossTurnDamage = bossDamage(); 
	    	bossTotDamage =  bossTotDamage + bossTurnDamage;
	    	this.currentHealth -= bossTurnDamage; 
	    	this.UpdateHealthBar();
	    }
    }

    private void UpdateHealthBar (){
    	float pctHealth = ((float)this.currentHealth / (float)this.healthHealer);
    	this._HealthBar.UpdateHealthBarAmount(pctHealth);
    }
}
