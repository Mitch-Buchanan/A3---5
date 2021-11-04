using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	[SerializeField]
    private int healthBoss = 5000; 
    [SerializeField]private int currentHealth;  
    private int i = 0; 
	//damages to boss hp
	private int mageTotDamage, tankTotDamage, druidTotDamage, rougeTotDamage = 0; 
    public int damageRouge () {return Random.Range(15, 25);}
    public int damageMage () {return Random.Range(5, 30);}
    public int damageDruid () {return Random.Range(5, 15);}
    public int damageTank () {return Random.Range(5, 10);}

    private HealthBar _HealthBar; 

    private void Awake () {
    	this._HealthBar = this.GetComponentInChildren<HealthBar>();

    	this.currentHealth = this.healthBoss;
    	this.UpdateHealthBar();
    }


   
    private void Update (){ 
    	i++; 
    	if (i % 100 == 0){
	    	int mageTurnDamage = damageMage(); 
	    	mageTotDamage =  mageTotDamage + mageTurnDamage;

	    	int tankTurnDamage = damageTank(); 
	    	tankTotDamage =  tankTotDamage + tankTurnDamage;

	    	int druidTurnDamage = damageDruid(); 
	    	druidTotDamage =  druidTotDamage + druidTurnDamage;

	    	int rougeTurnDamage = damageRouge(); 
	    	rougeTotDamage =  rougeTotDamage + rougeTurnDamage;

	    	this.currentHealth -= mageTurnDamage + tankTurnDamage + druidTurnDamage + rougeTurnDamage; 
	    	this.UpdateHealthBar();
	    }
    }

    private void UpdateHealthBar (){
    	float pctHealth = ((float)this.currentHealth / (float)this.healthBoss);
    	this._HealthBar.UpdateHealthBarAmount(pctHealth);
    }

}
