using UnityEngine;

public class PropertyBlock : MonoBehaviour
{
    public Material material;
    public new Renderer renderer;

    [Range(0, 1)]
    public  float floatValue;

    private MaterialPropertyBlock materialPropertyBlock;

    private void Start()
    {
        materialPropertyBlock = new MaterialPropertyBlock();
    }

    void Update ()
    {
        materialPropertyBlock.SetFloat("_FloatValue", floatValue);
        renderer.SetPropertyBlock(materialPropertyBlock);

        Debug.Log(material.GetInstanceID());
        Debug.Log(renderer.sharedMaterial.GetInstanceID());
    }
}