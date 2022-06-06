using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform posisiplayer;

    private void Update()
    {
        transform.position = new Vector3(posisiplayer.position.x, posisiplayer.position.y, transform.position.z);
    }
}
