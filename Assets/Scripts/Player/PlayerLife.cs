using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerLife : MonoBehaviour
{
    public UnityEvent Died;
    public CoinTakenEvent CoinTaken;

    private int _purse;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Barrier barrier))
        {
            Died.Invoke();
        }
        else if (other.TryGetComponent(out Coin coin))
        {
            _purse++;
            CoinTaken.Invoke(_purse);

            Destroy(other.gameObject);
        }
    }
}

[System.Serializable]
public class CoinTakenEvent : UnityEvent<int> { }
