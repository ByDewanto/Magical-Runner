using System.Collections;
using UnityEngine;

public class publicScript : MonoBehaviour
{
    public int randomNumberGenerator(int length){
        return Random.Range(0, length);
    }
}