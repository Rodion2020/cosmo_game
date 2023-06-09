using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    // Start is called before the first frame update

    public Rect levelBounds;

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, levelBounds.xMin,
            levelBounds.xMax), transform.position.y,
            Mathf.Clamp(transform.position.z,
            levelBounds.yMin, levelBounds.yMax));
    }

    void OnDrawGizmosSelected()
    {
        const int cubeDeplth = 1;
        Vector3 boundsCenter = new Vector3(levelBounds.xMin +
            levelBounds.width * 0.5f, 0, levelBounds.yMin +
            levelBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(levelBounds.width,
            cubeDeplth, levelBounds.height);
        Gizmos.DrawWireCube(boundsCenter, boundsHeight);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
