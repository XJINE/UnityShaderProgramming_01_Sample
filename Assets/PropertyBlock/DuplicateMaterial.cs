using UnityEngine;

public class DuplicateMaterial : MonoBehaviour
{
    public Material material;
    public new Renderer renderer;

    [Range(0, 1)]
    public  float floatValue;

    void Update ()
    {
        renderer.material.SetFloat("_FloatValue", floatValue);
        // renderer.sharedMaterial.SetFloat("_FloatValue", floatValue);

        Debug.Log(material.GetInstanceID());
        Debug.Log(renderer.material.GetInstanceID());
    }
}