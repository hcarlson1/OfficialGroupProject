using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public int numberOfCoins = 1;

	private int count;
	
	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText();
		winText.text = "";
	}


	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("coin"))
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
		
	}
	
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= numberOfCoins)
		{
			winText.text = "You Win!";
		}
	}
}
