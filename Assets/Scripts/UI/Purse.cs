using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Purse : MonoBehaviour
{
    [SerializeField] private TMP_Text _value;

    public void ShowPurse(int value)
    {
        _value.text = value.ToString();
    }
}
