using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;


    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }

    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        GameObject prefab= Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity)as GameObject;
        prefab.transform.localEulerAngles = new Vector3(0, 90, 0);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    }

}
