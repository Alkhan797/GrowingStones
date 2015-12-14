using UnityEngine;
using System.Collections;

public class tile : MonoBehaviour {

    public GameObject white_stone;
    public GameObject black_stone;
    private Manager manager;
    private GameObject stone;
    private bool stone_set;
    private float x;
    private float z;
    public int x_id;
    public int y_id;

	// Use this for initialization
	void Start () {
        manager = GameObject.Find("GameManager").GetComponent<Manager>();
        x = gameObject.transform.position.x;
        z = gameObject.transform.position.z;
        stone_set = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTouchDown()
    {
        if (manager.game_status == 1)
        {
            if (!stone_set)
            {
                if (manager.player_human)
                {
                    stone = Instantiate(white_stone, new Vector3(x, 0.281f, z - 0.2f), Quaternion.identity) as GameObject;
                    manager.Pass();
                }
                else if (!manager.player_human)
                {
                    stone = Instantiate(black_stone, new Vector3(x, 0.281f, z - 0.2f), Quaternion.identity) as GameObject;
                    manager.Pass();
                }
                stone.transform.parent = gameObject.transform;
                stone_set = true;
            }
        }
    }

    void OnTouchUp ()
    {

    }

    void OnTouchStay ()
    {

    }
}
