using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageCenterController : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float hue = 0.1f;
    public string villageTag;
    public int initialVillagerCount = 5;

    public GameObject VillagerPrefab;
    public List<GameObject> villagerTracker = new List<GameObject>();


    public void generateVillager()
    {
        var spawnpos = Random.insideUnitSphere;
        GameObject npc = Instantiate(VillagerPrefab, new Vector3(spawnpos.x, 0, spawnpos.z), transform.rotation);
        npc.GetComponent<VillagerController>().VillagePointRef = gameObject;
        npc.tag = villageTag;
        var npc_def_ref = npc.transform.Find("default");
        var vmat = npc_def_ref.GetComponent<MeshRenderer>().material;
        vmat.color = Color.HSVToRGB(hue, 1.0f, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initialVillagerCount; i++)
        {
            generateVillager();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
