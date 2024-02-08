using UnityEngine;

public class Rope : MonoBehaviour {

	public Rigidbody2D hook;
	public GameObject linkPrefab;
	public Weight weigtht;
	private Vector3 scaleChange;
	private float a = 0;
	public int links = 5;
	
	
	GameObject link;

	void Start () {
		
		GenerateRope();
		Destroy(gameObject, 3);
	}

	public void NewWhight(Weight weigthtObject)
    {
		weigtht = weigthtObject;

	}

	void GenerateRope ()
	{
		Rigidbody2D previousRB = hook;
		
		for (int i = 0; i < links; i++) //create ropes
		{
			link = Instantiate(linkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
			joint.connectedBody = previousRB;
			previousRB = link.GetComponent<Rigidbody2D>();
			
		}
		weigtht.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
	}
    private void Update()
    {
		transform.Translate(0.005f, 0, 0);
	}

}
