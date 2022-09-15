
using UnityEngine;

public class Collision : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
   switch (other.gameObject.tag)
    {
    case "Friendly":
        Debug.Log("No damage assessed");
        break;
    case "Finish":
        Debug.Log("Flight completed");
        break;
    case "Ground Obstacle":
        Debug.Log("Damage assessed");
        break;
    case "Air Obstacle":
        Debug.Log("Damage assessed");
        break;
    default :
        Debug.Log("Overwhelming Damage") ;
        break;
   }
   }
}
