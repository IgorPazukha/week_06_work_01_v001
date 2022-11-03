using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisabled : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private bool _isStatus = false;

    public void OnButtonClick()
    {
        _gameObject.SetActive(_isStatus);
    }
}
