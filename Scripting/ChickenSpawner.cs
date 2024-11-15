using UnityEngine;

public class ChickenSpawner:MonoBehaviour
{
    public Vector3 ChickenSpawnPosition;
    public GameObject chicken;
    public GameObject chickenCoop;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(chicken, ChickenSpawnPosition, Quaternion.identity);
            GameObject p = Instantiate(chicken, ChickenSpawnPosition, Quaternion.identity);
            gameObject.SetActive(false);
        }

    }

    private void OnEnterBarn()
    {
        Destroy(gameObject);
    }
}
