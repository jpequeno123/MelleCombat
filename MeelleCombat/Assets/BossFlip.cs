using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFlip : MonoBehaviour
{

	public Animator animator;

	public Transform player;

	public bool isFlipped=false;

	public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;
			if (transform.position.x > player.position.x && isFlipped)
			{
				transform.localScale = flipped;
				transform.Rotate(0f, 180f, 0f);
				isFlipped = false;
			}
			else if (transform.position.x < player.position.x && !isFlipped)
			{

				transform.localScale = flipped;
				transform.Rotate(0f, 180f, 0f);
				isFlipped = true;
			}
//		if (transform.rotation.eulerAngles.y == -180)
//		{
//			if (transform.position.x < player.position.x && isFlipped)
//			{
//				transform.localScale = flipped;
//				transform.Rotate(0f, 180f, 0f);
//				isFlipped = false;
//			}
//			else if (transform.position.x > player.position.x && !isFlipped)
//			{
//
//				transform.localScale = flipped;
//				transform.Rotate(0f, 180f, 0f);
//				isFlipped = true;
//
//			}

		if (isFlipped == true)
        {
			animator.SetBool("Iflipped",true);
        }
		if (isFlipped == false)
		{
			animator.SetBool("Iflipped", false);
		}
	}

}
