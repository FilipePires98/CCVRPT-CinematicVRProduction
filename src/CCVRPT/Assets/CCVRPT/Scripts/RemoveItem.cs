using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveItem : MonoBehaviour {

    public HandMenu_Playground handMenu;

    // Start and Update Functions

    void Start() {
       
    }

    void Update() {
        
    }

    // Spawn Functions 

    public void Remove(GameObject item) {
        
        if(!item && !handMenu){
            //Debug.Log("Failed to ")
            return;
        }
        
        if(handMenu != null) {
            handMenu.removeObject(item);
        }
        Destroy(item);
        
        Debug.Log("Removing object");
    }
}