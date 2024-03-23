using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] private float _speed;

	private void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, transform.forward, _speed * Time.deltaTime);
	}
}
