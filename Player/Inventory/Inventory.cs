using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Inventory : MonoBehaviour
{
    public GameObject[] inventory_slots = new GameObject[9];
    private GameObject to_instantiate;
    private Vector3 pos_to_add;
    private Quaternion rot_to_add;

    // Start is called before the first frame update
    void Start()
    {
        int i;

        i = 0;
        while (i < 9)
        {
            inventory_slots[i] = null;
            i++;
        }
        to_instantiate = null;
    }

    int check_item_inventory(string to_find)
    {
        int i;

        i = 0;
        while (i < 9 && inventory_slots[i])
        {
            if (inventory_slots[i].name == to_find)
                return (i);
            i++;
        }
        return (-1);
    }

    void spawn_light()
    {
        to_instantiate = Instantiate(inventory_slots[check_item_inventory("Lighter")], transform.Find("MainCamera"));
        to_instantiate.transform.position = GameObject.Find("Player").transform.position;
        to_instantiate.transform.rotation = GameObject.Find("Player").transform.rotation;
        pos_to_add = to_instantiate.transform.position;
        pos_to_add.z += 1.37f;
        to_instantiate.transform.position = pos_to_add;
        rot_to_add = to_instantiate.transform.rotation;
        to_instantiate.transform.rotation = rot_to_add;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (check_item_inventory("Lighter") > -1)
            {
                Debug.Log("Lighet is find in inventory_slot");
                spawn_light();
            }
        }
    }
}
