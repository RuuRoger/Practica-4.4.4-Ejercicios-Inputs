using UnityEngine;

public class Scene2Player : MonoBehaviour
{
    //Public properties
    public float speed;

    //Private attributes
    private float _randomX;
    private float _randomz;

    //Methods
    private void Update()
    {
        //Player movement
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime * Vector3.right);
        transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime * Vector3.forward);

        //Teleportation player
        if (Input.GetKeyUp(KeyCode.T) || Input.GetButtonUp("Fire1")) //Because i like and preffer play with control, so i made this option
        {
            _randomX = Random.Range(-93f, 92f); //Aproximately the limits in x-axis' plane 
            _randomz = Random.Range(-90, 89);//Aproximately the limits in z-axis' plane
            transform.position = new Vector3(_randomX, 7, _randomz);
        }    
    }
}
