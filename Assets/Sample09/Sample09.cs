using UnityEngine;

[ExecuteInEditMode]
public class Sample09 : MonoBehaviour
{
    public Material material;

    [Range(0, 1)]
    public float floatValue;
    public Color globalColorValue;

    private int floatValueId;
    private int globalColorValueId;

    void Start ()
    {
        this.floatValueId = Shader.PropertyToID("_FloatValue");
        this.globalColorValueId = Shader.PropertyToID("_GlobalColorValue");
    }

    void Update ()
    {
        this.material.SetFloat("_FloatValue", this.floatValue);
        this.material.SetFloat(floatValueId, this.floatValue);

        Shader.SetGlobalColor(globalColorValueId, this.globalColorValue);
    }
}