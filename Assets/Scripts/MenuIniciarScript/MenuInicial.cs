using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    
   //Chama a tela de new game
    public void ChamaTela()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

}
