using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickAnItem : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public string TagCollision;
    public GameObject Slot1;
    Inventory  player_script_inventory;
   // public GameObject sprite_item;
    PickAnItem pick_an_item;
    GameObject slot_inv_to_modify;

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            //Debug.Log("entered");
        }
    }

    private void pick_item(GameObject player)
    {
        player_script_inventory = player.GetComponent<Inventory>();
        pick_an_item = player.GetComponent<PickAnItem>();
        if (player_script_inventory.inventory_slots[0] == null)
        {
            player_script_inventory.inventory_slots[0] = gameObject.GetComponent<PrefabItem>().Prefabitem;
            gameObject.GetComponent<PrefabItem>().Canvas_Player_Inventory.GetComponent<Image>().sprite = gameObject.GetComponent<PrefabItem>().image;
            //ot_inv_to_modify = pick_an_item
            // slot_inv_to_modify = pick_an_item.sprite_item;
           // slot_inv_to_modify =

            return;
        }
      /*  else if (player_script_inventory.slot2 == null)
        {
            return;
        }
        else if(player_script_inventory.slot3 == null)
        {
            return;
        }
        else if (player_script_inventory.slot4 == null)
        {
            return;
        }
        else if (player_script_inventory.slot5 == null)
        {
            return;
        }
        else if (player_script_inventory.slot6 == null)
        {
            return;
        }
        else if (player_script_inventory.slot7 == null)
        {
            return;
        }
        else if (player_script_inventory.slot8 == null)
        {
            return;
        }
        else if (player_script_inventory.slot9 == null)
        {
            return;
        }*/
    }

    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            //  Debug.Log("stay");
            if (other.gameObject.tag == TagCollision)
            {
                if (Input.GetButton("Fire1"))
                {
                    pick_item(other.gameObject);
                    GameObject.Destroy(gameObject);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
         //   Debug.Log("exit");
        }
    }
}
