using UnityEngine;

public class Rotate : Transformation
{
    public Vector3 mRotation;

    public override Matrix4x4 Matrix {
        get {
            float radX = mRotation.x * Mathf.Deg2Rad;
            float radY = mRotation.y * Mathf.Deg2Rad;
            float radZ = mRotation.z * Mathf.Deg2Rad;

            float sinX = Mathf.Sin(radX);
            float cosX = Mathf.Cos(radX);

            float sinY = Mathf.Sin(radY);
            float cosY = Mathf.Cos(radY);

            float sinZ = Mathf.Sin(radZ);
            float cosZ = Mathf.Cos(radZ);

            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetColumn(0, new Vector4(
                cosY * cosY,
                cosX * sinZ + sinX * sinY * cosZ,
                sinX * sinZ - cosX * sinY * cosZ,
                0.0f
            ));

            matrix.SetColumn(1, new Vector4(
                -cosY * sinZ,
                cosX * cosZ - sinX * sinY * sinZ,
                sinX * cosZ + cosX * sinY * sinZ,
                0.0f
            ));

            matrix.SetColumn(2, new Vector4(
                sinY,
                -sinX * cosY,
                cosX * cosY,
                0.0f
            ));

            matrix.SetColumn(3, new Vector4(0f, 0f, 0f, 1f));
            return matrix;
        }
    }
}
