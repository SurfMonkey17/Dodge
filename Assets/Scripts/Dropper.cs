using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float _timeToWait = 2f;
    MeshRenderer meshRenderer;
    private new Rigidbody rigidbody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    
    void Update()
    {
        if (Time.time > _timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
