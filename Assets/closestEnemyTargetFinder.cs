using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestEnemyTargetFinder : MonoBehaviour
{
    private bool targetAquired = false;
    private AIDestinationSetter aIDestinationSetter;

    void Start()
    {
        aIDestinationSetter = GetComponent<AIDestinationSetter>();
        setTarget(findClosestEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        if (targetAquired == false)
        {
            Transform potentialTarget = findClosestEnemy();
            if (potentialTarget != null)
            {
                setTarget(potentialTarget);
                targetAquired = true;
            }
        }
    }

    private Transform findClosestEnemy()
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        Debug.Log("Number of enemies found: " + GameObject.FindGameObjectsWithTag("enemy").Length);
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("enemy")) {
            Vector3 directionToTarget = enemy.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if(dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = enemy.transform;
            }
        }
        return bestTarget;
    }

    private void setTarget(Transform target)
    {
        aIDestinationSetter.target = target;
    }
}
