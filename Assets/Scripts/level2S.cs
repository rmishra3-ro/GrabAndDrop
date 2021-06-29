using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2S : MonoBehaviour
{
    public void level2(string scene){
        SceneManager.LoadScene(scene);
    }
}
