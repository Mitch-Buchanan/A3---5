using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image Fill; 
	public void UpdateHealthBarAmount (float pctHealth){
		this.Fill.fillAmount = pctHealth;
	}

}
