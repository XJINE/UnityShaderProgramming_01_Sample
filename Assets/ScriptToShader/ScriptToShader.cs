using UnityEngine;

public class ScriptToShader : MonoBehaviour
{
    public Material material;

    [Range(0, 1)]
    public  float floatValue;
    private int   floatValueId;

    void Start ()
    {
        floatValueId = Shader.PropertyToID("_FloatValue");
    }

    void Update ()
    {
        material.SetFloat("_FloatValue", floatValue);
        material.SetFloat(floatValueId,  floatValue);
    }
}