using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private int keyCount;
    
    // Start is called before the first frame update
    void Start()
    {
        keyCount = 10;
        
        
    }

    void Update()
    {

    }



    void OnCollisionEnter (Collision other)
    {
        int count =0;
        List<string> itemList = Managers.Inventory.GetItemList();
        foreach (string item in itemList)
        {
            count += Managers.Inventory.GetItemCount(item);
        }

        Debug.Log("Door Triggered");
        Debug.Log(count);
        //if gameobject hasnt been destroyed and there are 10 Gemstones in the inventory, destroy the gameobject
        if (other.gameObject.tag == "Player" && count >= keyCount)
        {
            Destroy(this.gameObject);
        }
    }
}
