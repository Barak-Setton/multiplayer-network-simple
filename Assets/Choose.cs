using UnityEngine;
using System.Collections;

public class Choose : MonoBehaviour {

    int choice;

    public GameObject netManager;

    public void onCube()
    {
        choice = 0;
        netManager.GetComponent<GameManagerScript>().btn1();
    }
    public void onSphere()
    {
        choice = 1;
        netManager.GetComponent<GameManagerScript>().btn2();
    }

    public void printChoice()
    {
        print(choice);
    }
}
