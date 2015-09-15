using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	[SerializeField]
	public Text ScoreText;

    private int m_score = 0;
	private float m_speed = 1;
	private bool m_rotate = false;
    // Update is called once per frame
    void Update()
    {
		UpdateUI();
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime* m_speed;
		if(m_rotate == true){
			this.transform.Rotate (Vector3.forward * -5);
			m_speed = 7;
		}
    }

	public int Addscore
	{
		get {return m_score;}
		set {m_score += value;}
	}   

	public float Slow
	{
		get {return m_speed;}
		set {m_speed = value;}
	}   

	public bool Rotate
	{
		get {return m_rotate;}
		set {m_rotate = value;}
	}
	void UpdateUI(){
		ScoreText.text = "Score: " + m_score;
	}
}
