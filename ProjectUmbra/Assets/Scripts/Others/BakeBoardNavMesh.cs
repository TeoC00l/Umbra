using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BakeBoardNavMesh : MonoBehaviour
{

    private NavMeshSurface navMeshSurface;

    // Start is called before the first frame update
    void Start()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
        InvokeRepeating("Bake", 0, 2);
    }

    private void Bake()
    {
        navMeshSurface.BuildNavMesh();
    }
}
