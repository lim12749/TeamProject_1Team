using UnityEngine;

public class test_from_test : MonoBehaviour
{
    public int sutja = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            sutja = sutja + 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(1, 0, 0));
        }
    }
}
