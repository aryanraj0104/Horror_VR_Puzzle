using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform player, destination;
 public GameObject player_gameObject;
 
 void OnTriggerEnter(Collider other){
  if(other.CompareTag("Player")){
   player_gameObject.SetActive(false);
   player.position = destination.position;
   player_gameObject.SetActive(true);
  }
 }
}
