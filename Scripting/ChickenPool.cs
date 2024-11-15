using UnityEngine;
using UnityEngine.Pool;

public class ChickenPool
{
    public List<GameObject> pooledObjects;
    public static ObjectPool SharedInstance;
    public GameObject objectToPool;
    public int amountToPool;
}
