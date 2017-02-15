using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class PlayerHealth : MonoBehaviour {

	public Slider healthSlider;

	[Range(0.00f, 1.00f)]
	public float startingHealth;

	private Animator anim;
	private float health;

	void Awake() {
		anim = GetComponent<Animator> ();
		health = startingHealth;
	}

	void Update () {
		UpdateHealth (); 
		anim.SetLayerWeight (2, 1.00f - health);
		healthSlider.value = health;
	}

	void UpdateHealth() {
		health -= Time.deltaTime * 0.2f;
		if (health < 0) {
			health = 0;
		}
	}
}
