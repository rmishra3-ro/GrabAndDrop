using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goLevel1 : MonoBehaviour
{   
    // Start is called before the first frame update
    public void playLevel(string lv)
    {
        SceneManager.LoadScene(lv);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
