using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {

        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime; 
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime; 
       

        transform.Translate(xValue, yValue, zValue);
    }
}
