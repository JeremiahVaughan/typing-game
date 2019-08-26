using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClauseManager : MonoBehaviour {

    public ResourceManager resourceManager;
    public CameraManager cameraManager;
    public ClauseSpawner clauseSpawner;
    public ClauseGenerator clauseGenerator;
    private Clause activeClause;

    private void Start()
    {
        AddClause();
    }

    private void AddClause()
    {
        ClauseDisplay clauseDisplay = clauseSpawner.spawnClause();

        activeClause = new Clause(clauseGenerator.getRandomClause(), clauseDisplay, this);

    }

    public void requestRespawn(int clauseValue)
    {
        resourceManager.requestResourcesBeAdded(clauseValue);
        AddClause();
    }

    public void TypeLetter(string letter)
    {
        activeClause.typeLetter(letter);
    }

    public void requestCameraShake()
    {
        cameraManager.requestCameraShake();
    }
    
}
