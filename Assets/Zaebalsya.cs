using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Zaebalsya : MonoBehaviour
{
    [SerializeField]
    private InputActionReference _menuAction;
    [SerializeField]
    private GameObject _main_menu;
    [SerializeField]
    private GameObject _settings;

    private bool _menuOpened = false;

   
    private void OnEnable()
    {
        _menuAction.action.performed += OnMenu;
    }
    private void OnDisable()
    {
        _menuAction.action.performed -= OnMenu;
    }

    private void OnMenu(InputAction.CallbackContext obj)
    {

            HandleMenu(!_menuOpened);
        
       
    }
    public void HandleMenu(bool state)
    {
        if (state)
        {
            Debug.Log("Opened");
            _main_menu.SetActive(true);
            _menuOpened = true;
        }
        else
        {
            Debug.Log("Closed");
            _main_menu.SetActive(false);
            _menuOpened = false;
        }
        _settings.SetActive(false);
    }
}
