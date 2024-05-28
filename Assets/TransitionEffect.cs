using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionEffect : MonoBehaviour
{
    [SerializeField]
    float radius;

    [SerializeField]
    float increaseSpeed = 0.1f; // Speed at which the radius increases

    public Animator anim;



    void Update()
    {
        Shader.SetGlobalVector("_Position", transform.position);
        Shader.SetGlobalFloat("_Radius", radius);
        anim.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("PlayAnimation");
        }
    }
}
