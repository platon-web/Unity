using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int index= 1;
private void OnTriggerEnter2D(Collider2D collider){
    if(collider.GetComponent<Weel>()!=null){
        SceneManager.LoadScene(index);
    }
}

}
