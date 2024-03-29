using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    float radius;

    [SerializeField]
    float increaseSpeed = 0.1f; // Speed at which the radius increases

    bool isIncreasing = false; // Flag to indicate if the radius is currently increasing


    void Update()
    {
        Shader.SetGlobalVector("_Position", transform.position);
        Shader.SetGlobalFloat("_Radius", radius);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player (or any other object you want to trigger the effect)
        if (other.CompareTag("Player") && !isIncreasing)
        {
            // Start increasing the radius
            StartCoroutine(IncreaseRadiusOverTime());
        }
    }

    IEnumerator IncreaseRadiusOverTime()
    {
        isIncreasing = true;
        while (radius < 55f)
        {
            // Increase the radius gradually over time
            radius += increaseSpeed * Time.deltaTime;
            yield return null;
        }
        isIncreasing = false;
    }

}
