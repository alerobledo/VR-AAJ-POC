using UnityEngine;
using System.Collections;

public class AAJCameraMovement : MonoBehaviour {

    public GameObject zPositionText;

    private bool girar = true;
    
	// Update is called once per frame
	void Update () {
        showPositionOnScreen();
  /*      //hacia adelante
        if (transform.position.z <8f)
            transform.Translate(Vector3.forward * Time.deltaTime);
        if (transform.position.z >= 8f && transform.localRotation.eulerAngles.y<90)
        {//gira hacia la derecha
            transform.Rotate(Vector3.up);
            //Debug.Log(Vector3.Angle(transform.position, new Vector3(0, 90, 0)));           
        }
        if(transform.localRotation.eulerAngles.y >= 90)
        {
            if (transform.position.x <4f)
                transform.Translate(Vector3.forward * Time.deltaTime);
        }*/
	}

    private void showPositionOnScreen()
    {
        zPositionText.GetComponent<TextMesh>().text = "("+transform.position.x.ToString().Substring(0, 1)
                                                        +", "+
                                                        transform.position.y.ToString().Substring(0, 1)+", " +
                                                        transform.position.z.ToString().Substring(0,1)+")";

    }
}
