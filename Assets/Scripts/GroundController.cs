using UnityEngine;

public class GroundController : MonoBehaviour
{

    public delegate void EventHandler();
    public event EventHandler GroundPound;

    public void FireGroundPound()
    {

        if (GroundPound != null)
        {

            GroundPound();

        }

    }

}
