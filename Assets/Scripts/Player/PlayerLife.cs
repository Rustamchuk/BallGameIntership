using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerLife : MonoBehaviour
{
    public UnityEvent _died;
    public CoinTakenEvent _coinTaken;

    private int _purse;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Barrier barrier))
        {
            _died.Invoke();
        }
        else if (other.TryGetComponent(out Coin coin))
        {
            _purse++;
            _coinTaken.Invoke(_purse);

            Destroy(other.gameObject);
        }
    }
}

[System.Serializable]
public class CoinTakenEvent : UnityEvent<int> { }
