using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;

    private void Update()
    {
        transform.position = new Vector3(_target.transform.position.x, -10, _target.transform.position.z);
    }
}
