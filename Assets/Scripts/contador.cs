using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class contador : MonoBehaviour {

    public Text contadorPlayer;
    public Text contador2Player;
    public Text contadorEnemigo;
    public Text contador2Enemigo;
	public Text gameOver;
    public Text reiniciar;

	public int vidasPlayer = 2;
	public int vidasEnemigo = 2;

    private int muertesPlayer = 0;
    private int muertesEnemigo = 0;
    private float time;

	public void restartGame() {
        muertesPlayer = -1;
        GameObject.Find ("Player").GetComponent<MovePlayer> ().muere ();
        Enemigo [] enemyComponents = GameObject.Find("Enemigos").GetComponentsInChildren<Enemigo> ();
        for (int i = 0; i < enemyComponents.Length; i++)
        {
            muertesEnemigo = -1;
            enemyComponents[i].muere();
        }

        GameObject [] balas = GameObject.FindGameObjectsWithTag("Bala");
        for (int i = 0; i < balas.Length; i++)
        {
            GameObject.Destroy(balas[i]);
        }
        balas = GameObject.FindGameObjectsWithTag("BalaEnemigo");
        for (int i = 0; i < balas.Length; i++)
        {
            GameObject.Destroy(balas[i]);
        }


        gameOver.text = "";
        reiniciar.enabled = false;
        Time.timeScale = time;
    }

    // Use this for initialization
    void Start () {
        time = Time.timeScale;
        reiniciar.enabled = false;
    }

    void Update ()
    {
        if (Time.timeScale == 0 && (Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.JoystickButton6)))
        {
            restartGame();
        }
    }
	
	public void muereJugador ()
    {
        muertesPlayer++;
        contadorEnemigo.text = muertesPlayer.ToString();
        string aux = "";
        if (muertesPlayer > 0)
        {
            for (int i = 1; i <= muertesPlayer; i++)
            {
                aux += "|";
                if (i % 5 == 0)
                    aux += "\n";
            }
        }
        contador2Enemigo.text = aux;

		if (muertesPlayer == vidasPlayer) {
			gameOver.text = "Game Over";
            gameOver.color = Color.red;
            gameOver.font = Resources.Load<Font>("fonts/BloodBlocks Project");
            reiniciar.enabled = true;
            Time.timeScale = 0;
        }
    }

    public void muereEnemigo()
    {
        muertesEnemigo++;
        contadorPlayer.text = muertesEnemigo.ToString();
        string aux = "";
        if (muertesEnemigo > 0)
        {
            for (int i = 1; i <= muertesEnemigo; i++)
            {
                aux += "|";
                if (i % 5 == 0)
                    aux += "\n";
            }
        }

        contador2Player.text = aux;

		if (muertesEnemigo == vidasEnemigo) {
			gameOver.text = "Victoria";
            gameOver.color = Color.green;
            gameOver.font = Resources.Load<Font>("fonts/OpenSansBold");
            reiniciar.enabled = true;
            Time.timeScale = 0;
        }
    }

    public void pausePressed ()
    {
        gameOver.text = "Pause";
        gameOver.color = Color.black;
        gameOver.font = Resources.Load<Font>("fonts/OpenSansBold");
        reiniciar.enabled = true;
        Time.timeScale = 0;
    }

    public void pauseUnPressed ()
    {
        Time.timeScale = time;
        gameOver.text = "";
        reiniciar.enabled = false;
    }

}
