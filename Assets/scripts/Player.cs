using UnityEngine;

public class Player : MonoBehaviour
{
	[Header("References")]
	
	public Material normalMat;
	

	[Header("Gameplay")]
	public float bounds = 3f;
	public float strafeSpeed = 4f;
	public float phaseCooldown = 2f;

	Renderer mesh;
	Collider collision;
	bool canPhase = true;

	void Start()
	{
		mesh = GetComponentInChildren<SkinnedMeshRenderer>();
		collision = GetComponent<Collider>();
	}

	void Update()
	{
		float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

		Vector3 position = transform.position;
		position.x += xMove;
		position.x = Mathf.Clamp(position.x, -bounds, bounds);
		transform.position = position;	
	}

	void PhaseIn()
	{
		mesh.material = normalMat;
		collision.enabled = true;
	}

}
