using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Animation_head_play : MonoBehaviour
{
    public GameObject player; 
    public GameObject targetObject; 
    private Animator targetAnimator;
    public GameObject sprite;


    public GameObject camB;

    void Start()
    {
        targetAnimator = targetObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            sprite.SetActive(false);


            
            if (targetAnimator != null)
            {
                targetAnimator.SetTrigger("Rise"); 
            }


            camB.SetActive(true);

            player.SetActive(false);
            

            StartCoroutine(Finishcut());
        }
    }


    IEnumerator Finishcut()
    {
        yield return new WaitForSeconds(20);
        

        player.SetActive(true);

        camB.SetActive(false);


    }


}
