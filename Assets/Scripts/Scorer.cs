using UnityEngine;

public class Scorer : MonoBehaviour
{

    [SerializeField] private int _score;
   
    
    private void OnCollisionEnter(Collision other)
    {
        _score += 1; 
        Debug.Log("You've bumped into something this many times: " + _score);
    }
}
