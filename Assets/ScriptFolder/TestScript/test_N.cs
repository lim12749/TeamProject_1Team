using UnityEngine;

public class test_N : MonoBehaviour
{
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 5) 
        {
            Debug.Log("Hellow_world!");
            count += 1;
        }

    }
}
