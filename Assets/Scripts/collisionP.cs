using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections;

public class collisionP : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text text;
    bool grabbedObj = false;
    public float wait = 1f;
    private float time;
    bool canTakeDamage = true;

    void Start()
    {
        text = GetComponent <Text>();
        currentHealth = maxHealth;
        GameObject.Find("Hnum").GetComponent<Text>().text = currentHealth + "";
        time = 0;
    }

    void Update() {
        time += Time.deltaTime;
        if(time > wait){
            canTakeDamage = true;
        } 
    }

    void TakeDamage(int damage){
        if (canTakeDamage) {
            currentHealth -= damage;
            canTakeDamage = false;
            time = 0;
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit){
        if (hit.gameObject.name == "grabObj") {
            Debug.Log("hit grab Object");
            grabbedObj = true;
            //text.text = currentHealth + " Health";
            hit.gameObject.SetActive(false);
            GameObject.Find("grabP").GetComponent<Text>().text = "Go to Red Destination";
        } else if (hit.gameObject.name == "destObj" && grabbedObj && currentHealth > 0) {
            Debug.Log("You win");
            if(SceneManager.GetActiveScene().name == "MyGame"){
                SceneManager.LoadScene("popUp");
            } 
            else if(SceneManager.GetActiveScene().name == "MyGame 1"){
                SceneManager.LoadScene("popUp 1");
            }
            Destroy(hit.gameObject);
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = CursorLockMode.None;
        } else if (hit.gameObject.name == "enemyD" ||hit.gameObject.name == "enemyD2"||hit.gameObject.name == "enemyD3"  ) {
            NavMeshAgent agent = hit.gameObject.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
            agent.isStopped = true;
            if (canTakeDamage){
                TakeDamage(40);
                if(currentHealth <= 0){
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
                }
            }
            Debug.Log(currentHealth);
            GameObject.Find("Hnum").GetComponent<Text>().text = currentHealth + "";
        } else if (hit.gameObject.name == "friendlyChar") {
            Debug.Log("Hit Health Bar");
            Destroy(hit.gameObject);
            TakeDamage(-30);
            if (currentHealth > 100)
                currentHealth = 100;
            GameObject.Find("Hnum").GetComponent<Text>().text = currentHealth + "";
        }
    
        

    }
    

    


}
