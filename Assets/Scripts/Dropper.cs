using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float _timeToWait = 2f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Time.time > _timeToWait)
        {
            Debug.Log("Look out below!");
        }
    }
}
