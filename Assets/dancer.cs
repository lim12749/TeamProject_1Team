using UnityEngine;

public class dancer : MonoBehaviour
{
    public Animator anime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            anime.SetTrigger("dance");
        }
    }
}
