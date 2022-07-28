using System;
using UnityEngine;
using Random = UnityEngine.Random;

class Collectable : MonoBehaviour
{
    public int value;
    [SerializeField] Bounds bounds;

    public void Collect()
    {
        // GameObject kikapcsolasa:
        // gameObject.SetActive(false);

        // GameObject torlese:
        // Destroy(gameObject);

        // Teleport:
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(x,y,z);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
