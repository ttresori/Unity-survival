using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health = 100;
    public int stamina = 100;
    public int mana = 100;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height / 10), "health : " + health);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
