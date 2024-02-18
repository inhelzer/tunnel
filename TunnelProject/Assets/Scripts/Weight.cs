using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
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
			
	}

	private void Update()
	{
		transform.Translate(0, 0, 0);
	}

	


}
