using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    private Material material;
    [SerializeField]
    private float velocity;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        material.mainTextureOffset += Vector2.right * velocity * Time.deltaTime;
    }
}