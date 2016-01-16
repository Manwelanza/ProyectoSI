using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class contador : MonoBehaviour {

    public Text contadorPlayer;
    public Text contador2Player;
    public Text contadorEnemigo;
    public Text contador2Enemigo;
	public Text gameOver;

	public int vidasPlayer = 2;
	public int vidasEnemigo = 2;

    private int muertesPlayer = 0;
    private int muertesEnemigo = 0;

	public int getMuertesPlayer() {
		return muertesPlayer;
	}

	public int getMuertesEnemigo() {
		return muertesEnemigo;
	}

	public void setMuertes(int _muertesPlayer, int _muertesEnemigo) {
		muertesPlayer = _muertesPlayer;
		muertesEnemigo = _muertesEnemigo;
	}

	public void restartGame() {

		setMuertes (0, 0);
		GameObject.Find ("Player").GetComponent<MovePlayer> ().muere ();
		Component [] enemyComponents = GameObject.Find ("Enemigos").GetComponentsInChildren<MovePlayer> ();
		for (int i = 0; i < enemyComponents.Length; i++)
			enemyComponents [i].GetComponent<MovePlayer> ().muere ();
	}

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

		if (muertesPlayer == vidasPlayer) {
			Time.timeScale = 0;
			gameOver.text = "Game Over";
		}
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

		if (muertesEnemigo == vidasEnemigo) {
			Time.timeScale = 0;
			gameOver.text = "Victoria";
		}
    }
}
