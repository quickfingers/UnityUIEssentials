using UnityEngine;

public class ShipMove : MonoBehaviour {
	void Start () {
		GetComponent<Rigidbody>().AddForce(Vector3.forward * 50, ForceMode.VelocityChange);
	}
}
