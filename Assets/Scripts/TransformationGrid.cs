using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationGrid : MonoBehaviour {

    public Transform mPrefab;
    public int mGridResolution = 10;
    Transform[] mGrid;

	// Use this for initialization
	void Start () {
        mGrid = new Transform[mGridResolution * mGridResolution * mGridResolution];

        for (int i = 0, z = 0; z < mGridResolution; z++) {
            for (int y = 0; y < mGridResolution; y++) {
                for (int x = 0; x < mGridResolution; x++, i++) {
                    mGrid[i] = CreateGridPoint(x, y, z);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    Transform CreateGridPoint (int x, int y, int z) {
        Transform point = Instantiate<Transform>(mPrefab);

        point.localPosition = GetCoordinates(x, y, z);
        point.GetComponent<MeshRenderer>().material.color = new Color (
            (float)x / mGridResolution,
            (float)y / mGridResolution,
            (float)z / mGridResolution

        );

        return point;
    }

    Vector3 GetCoordinates (int x, int y, int z) {
        return new Vector3 (
            x - (mGridResolution - 1) * 0.5f,
            y - (mGridResolution - 1) * 0.5f,
            z - (mGridResolution - 1) * 0.5f
        );
    }
}
