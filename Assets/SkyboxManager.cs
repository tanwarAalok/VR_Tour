using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void SkyboxChange(Material material){
        RenderSettings.skybox = material;
    }
}
