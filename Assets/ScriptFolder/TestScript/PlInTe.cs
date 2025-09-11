using UnityEngine;

public class PlInTe : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1, 2, 1);

        int a = Random.Range(0, 100);
        //Debug.Log(a);

        if (a == 7)
        {
            Debug.Log("7");
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (a == 77)
        {
            Debug.Log("-7");
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
