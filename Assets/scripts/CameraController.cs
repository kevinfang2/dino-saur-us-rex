using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject dino;
    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - dino.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = dino.transform.position + offset;
    }
}
