using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class show10Sec : MonoBehaviour
{
    public float wait = 10f;
    public string goingToLevel2;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      time += Time.deltaTime;
      if(time > wait){
          SceneManager.LoadScene(goingToLevel2);
      }  
    }
}
