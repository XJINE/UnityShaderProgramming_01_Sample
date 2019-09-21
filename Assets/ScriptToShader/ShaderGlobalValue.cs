using UnityEngine;

public class ShaderGlobalValue : MonoBehaviour
{
    [Range(0, 1)]
    public  float floatValue;
    private int   floatValueId;

    void Start ()
    {
        floatValueId = Shader.PropertyToID("_FloatValue");
    }

    void Update ()
    {
        Shader.SetGlobalFloat("_FloatValue", floatValue);
        Shader.SetGlobalFloat(floatValueId,  floatValue);
    }
}