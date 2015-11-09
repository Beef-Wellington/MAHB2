using UnityEngine;
using System.Collections;

//gets implemented into every ui Button ()
abstract public class Button : MonoBehaviour {

	//implemented into action buttons (buttons that control Skinny [piss, drink beer, etc.])
	abstract public void action ();
}
