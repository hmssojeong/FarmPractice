using UnityEngine;

public class GameGrid : MonoBehaviour
{
    public int columnLength, rowLength;
    public float x_Space, z_Space;

    public GameObject grass;
    public GameObject[] currentGrid;

    public bool gotGrid;

    private void Start()
    {
        for(int i =0; i<columnLength*rowLength; i++)
        {
            Instantiate(grass, new Vector3(x_Space + (x_Space * (i % columnLength)), 0, z_Space + (z_Space * (i / columnLength))), Quaternion.identity);
        }
    }

    private void Update()
    {
        if(gotGrid == false)
        {
            currentGrid = GameObject.FindGameObjectsWithTag("grid");

            gotGrid = true;
        }
    }
}
