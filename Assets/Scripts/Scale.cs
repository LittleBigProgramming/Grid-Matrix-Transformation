using UnityEngine;

public class Scale :  Transformation {

    public Vector3 mScale;

    public override Vector3 Apply(Vector3 point) {
        point.x *= mScale.x;
        point.y *= mScale.y;
        point.z *= mScale.z;

        return point;
    }
}
