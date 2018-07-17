using UnityEngine;

public class Sample09P : MonoBehaviour
{
    public GameObject targetGameObjectA;

    void Update ()
    {

        Material[] materials = GameObject.FindObjectsOfType<Material>();

        Debug.Log("MATERIAL_COUNT_IN_SCENE : " + materials.Length);

        for (int i = 0; i < materials.Length; i++)
        {
            Debug.Log(materials[i].name);
        }

        this.targetGameObjectA.GetComponent<Renderer>()
            .sharedMaterial.SetFloat("_FloatValue", Random.value);
    }
}