using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();       
    } 
    
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Win the game by avoiding all the obstacles");
        Debug.Log("Move using the arrow keys or WASD");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
