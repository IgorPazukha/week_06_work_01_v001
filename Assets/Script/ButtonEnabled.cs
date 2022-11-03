using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnabled : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    
    private bool _isStatus = true;

    public void OnButtonClick()
    {
        _gameObject.SetActive(_isStatus);
    }
}
