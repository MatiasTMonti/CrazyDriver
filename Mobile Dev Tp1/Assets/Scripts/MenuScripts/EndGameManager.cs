using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    [SerializeField] private MultiplayerScriptableObject multiplayer;
    [SerializeField] private TMPro.TextMeshProUGUI textWin1;
    [SerializeField] private TMPro.TextMeshProUGUI textWin2;

    private TMPro.TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        if (multiplayer.isMultiplayer)
        {
            if (DatosPartida.player1Points > DatosPartida.player2Points)
            {
                text.text = "Congratulations\nPlayer 1 win with:\n$" + DatosPartida.player1Points;
                if (textWin1.IsActive())
                {
                    textWin1.text = "Congratulations\nPlayer 1 win with:\n$" + DatosPartida.player1Points;
                }
            }
            else if (DatosPartida.player1Points < DatosPartida.player2Points)
            {
                text.text = "Congratulations\nPlayer 2 win with:\n$" + DatosPartida.player2Points;
                if (textWin2.IsActive())
                {
                    textWin2.text = "Congratulations\nPlayer 2 win with:\n$" + DatosPartida.player2Points;
                }
            }
            else
            {
                text.text = "Congratulations\nBoth player win with:\n$" + DatosPartida.player1Points;
            }
        }
        else
        {
            text.text = "Congratulations\nYour recollected:\n$" + DatosPartida.player1Points;
        }
    }
}
