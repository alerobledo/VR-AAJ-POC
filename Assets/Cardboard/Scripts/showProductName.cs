using UnityEngine;
using System.Collections;

public class showProductName : MonoBehaviour {

    public GameObject zPositionText;
    public string productName;

    public void DisplayProductName()
    {
        zPositionText.GetComponent<TextMesh>().text = productName;
    }
    
}
