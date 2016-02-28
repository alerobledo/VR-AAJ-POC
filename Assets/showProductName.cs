using UnityEngine;
using System.Collections;

public class showProductName : MonoBehaviour {

    public GameObject zPositionText;

    public void DisplayProductName()
    {
        Debug.Log("Quilmes touchedddddddd");
        zPositionText.GetComponent<TextMesh>().text = "Quilmes Cristal 1L - $15";
    }
    
}
