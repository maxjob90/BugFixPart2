using System;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;

    private GameObject _tempPrefab;
    private void Start()
    {
        _tempPrefab = Instantiate(_shelfPrefab).gameObject; // Эту строку кода удалять нельзя
        Destroy(_tempPrefab);
    }
}
