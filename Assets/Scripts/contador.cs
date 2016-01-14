using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class contador : MonoBehaviour {

    public Text contadorPlayer;
    public Text contador2Player;
    public Text contadorEnemigo;
    public Text contador2Enemigo;

    private int muertesPlayer = 0;
    private int muertesEnemigo = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	public void muereJugador ()
    {
        muertesPlayer++;
        contadorEnemigo.text = muertesPlayer.ToString();
        string aux = "";
        for (int i = 1; i <= muertesPlayer; i++)
        {
            aux += "|";
            if (i%5 == 0)
                aux += "\n";
        }
        contador2Enemigo.text = aux;
    }

    public void muereEnemigo()
    {
        muertesEnemigo++;
        contadorPlayer.text = muertesEnemigo.ToString();
        string aux = "";
        for (int i = 1; i <= muertesEnemigo; i++)
        {
            aux += "|";
            if (i%5 == 0)
                aux += "\n";
        }
        contador2Player.text = aux;
    }
}
