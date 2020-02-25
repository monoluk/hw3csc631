
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Material material;
    Renderer rend;

    void Start(){
        rend = GetComponent<Renderer>();
        //rend.sharedMaterial = material;
    }
    
    public void changeMaterial(){
        rend.sharedMaterial = material;
    }

}
