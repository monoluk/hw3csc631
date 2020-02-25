
using UnityEngine;

public class Barrel : MonoBehaviour
{

    bool exploding = true;
    public GameObject explosionEffect;
//    void OnTriggerEnter(){
//        if(collisionInfo.collider.tag == "Vehicle"){
//         Instantiate(explosionEffect, transform.position, transform.rotation);}
//     }

 void OnCollisionEnter(Collision collisionInfo){

     if(collisionInfo.collider.tag == "vehicle"){
         if(exploding){
    Instantiate(explosionEffect, transform.position, transform.rotation);
    Destroy(gameObject);
    exploding = false;}
     }
 }
    

}
