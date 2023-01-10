using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // public GameObject destroyDog;
    private bool clkDwn = true;
    [SerializeField] private float timer = 1f;

    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && clkDwn)    
        {
            clkDwn = false;
                     
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(Fade());
            
        }
            
    }
        
    IEnumerator Fade()
    {        
            yield return new WaitForSeconds(timer);
            clkDwn = true;
    }

}
