using UnityEngine;
using UnityEngine.SceneManagement;

public class Weight : MonoBehaviour {

	public float distanceFromChainEnd = 0.6f;

	public void ConnectRopeEnd (Rigidbody2D endRB)
	{
		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
		joint.autoConfigureConnectedAnchor = false;
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd);
		Destroy(gameObject,3);	
	}

	private void Update()
	{
		transform.Translate(-0.005f, 0, 0);
	}

	


}
