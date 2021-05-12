using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class DestroyOnCollision : MonoBehaviour
{




	//here we will destroy the game object the script is attached to if it collides with the player, as long as the tag "Player" has been assigned to the player.

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
			Destroy(gameObject);

	}
}