using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceColliderType : MonoBehaviour
{
    public enum Mode { Concrete, Metal }

    public Mode TerrainType;

    public string GetTerrainType()
    {
        string typeString = "";

        switch (TerrainType)
        {
            case Mode.Concrete:
                typeString = "Concrete";
                break;
            case Mode.Metal:
                typeString = "Metal";
                break;
            default:
                typeString = "";
                break;
        }
        return typeString;
    }
}
