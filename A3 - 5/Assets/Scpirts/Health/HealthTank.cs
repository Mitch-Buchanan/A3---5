using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTank : MonoBehaviour
{
    [SerializeField] private int healthTank = 3000; 
    [SerializeField] private int currentHealth;  
    private int i = 0; private int bossTotDamage; 
    public GameOverScreen GameOverScreen;
    private HealthBar _HealthBar; 

    private void Awake () {
    	this._HealthBar = this.GetComponentInChildren<HealthBar>();

    	this.currentHealth = this.healthTank;
    	this.UpdateHealthBar();
    }

    public int bossDamage (){return Random.Range(40, 50);}
   
    private void Update (){ 
    	i++; 
    	if (currentHealth < 1){
    		Destroy(GetComponent<MeshRenderer>());
            GameOver();
    	}
    	if (i % 100 == 0){
    		int bossTurnDamage = bossDamage(); 
	    	bossTotDamage =  bossTotDamage + bossTurnDamage;
	    	this.currentHealth -= bossTurnDamage; 
	    	this.UpdateHealthBar();
	    }
    }

    private void UpdateHealthBar (){
    	float pctHealth = ((float)this.currentHealth / (float)this.healthTank);
    	this._HealthBar.UpdateHealthBarAmount(pctHealth);
    }
     public void GameOver() {
        GameOverScreen.Setup();
    }
}
