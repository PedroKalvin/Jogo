﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour {

 public float vida = 100;
 bool chamouMorte = false;

 void Update () 
 {
    if (vida <= 0) 
    {
     vida = 0;
      if (chamouMorte == false) 
       {
        chamouMorte = true;
        StartCoroutine ("Morrer");
       }
     }
 }

 IEnumerator Morrer(){
 GetComponent<MeshRenderer> ().material.color = Color.red;
 yield return new WaitForSeconds (1);
 Destroy (gameObject);
  SceneManager.LoadScene("Vitoria");
  Destroy (GameObject.FindWithTag("Player"));
 }
}