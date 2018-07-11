using UnityEngine;

public class Sample09 : MonoBehaviour
{
    public GameObject targetGameObjectA;
    public GameObject targetGameObjectB;

    private MaterialPropertyBlock materialPropertyBlock;

    public void Start()
    {
        this.materialPropertyBlock = new MaterialPropertyBlock();
    }

    public void Update()
    {

        Material[] materials = GameObject.FindObjectsOfType<Material>();

        Debug.Log("MATERIAL_COUNT_IN_SCENE : " + materials.Length);

        for (int i = 0; i < materials.Length; i++)
        {
            Debug.Log(materials[i].name);
        }

        // CASE:1
        this.targetGameObjectA.GetComponent<Renderer>().material.SetFloat("_FloatValue", Random.value);

        // CASE:2
        //this.materialPropertyBlock.SetFloat("_FloatValue", Random.value);
        //this.targetGameObjectA.GetComponent<Renderer>().SetPropertyBlock(this.materialPropertyBlock);
    }
}