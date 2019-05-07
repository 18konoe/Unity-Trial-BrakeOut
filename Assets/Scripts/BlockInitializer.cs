using UnityEngine;
using System.Collections;
using System.Linq;

public class BlockInitializer : MonoBehaviour
{
    public GameObject BlockPrefab;
    public GameObject Blocks;
    void Awake()
    {
        GameObject masterObject = GameObject.Find("Master");
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                GameObject gameObject = Instantiate(BlockPrefab, Blocks.transform);
                gameObject.transform.position = new Vector3(2f + (1f * y), 0.4f, (-4.2f + (1.2f * x)));
                gameObject.GetComponent<BlockDestroyer>().MasterObject = masterObject;
            }
        }
        Enumerable.Range(0, 8).Select(x =>
        {
            Enumerable.Range(0, 5).Select(y =>
            {

                return 0;
            });
            return 0;
        });
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
