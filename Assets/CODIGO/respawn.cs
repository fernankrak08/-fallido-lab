using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Respawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {

        if (transform.position.y < -1)
        {
            transform.position = Respawn.transform.position;
            print("Vuelve a empezar");
        }

        if(Input.GetKey(KeyCode.R))
        {
            transform.position = Respawn.transform.position;
            print("Vuelve a empezar");
        }
    }
}
