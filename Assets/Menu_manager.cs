using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_manager : MonoBehaviour
{
    [SerializeField] GameObject Main_menu;
    
    void Update()
    {
        if (Input.GetKeyDown("XRI_Left_MenuButton"))
        {
            Main_menu.SetActive(true);
        }
    }
}
