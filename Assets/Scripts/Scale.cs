﻿using UnityEngine;

public class Scale :  Transformation {

    public Vector3 mScale;

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(mScale.x, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, mScale.y, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, mScale.z, 0f));
            matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
            return matrix;
        }
    }
}
