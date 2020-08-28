using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clipping : MonoBehaviour
{
    // Start is called before the first frame update

    private int qtdepecas;
    private Vector2 dimensions;//resolutionpieces
    private Texture2D texturas;//sourceTexture
    public Dropdown dropdown;
    private List<Vector2> possiveisposicoes = new List<Vector2>();
    private List<Vector2> posicoessorteadas = new List<Vector2>();
    private Vector2 posicao, dispecas;
    void Start()
    {
        dimensions = new Vector2(texturas.width / qtdepecas,texturas.height / qtdepecas);
        qtdepecas = dropdown.value;
        Debug.Log(qtdepecas);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private Texture2D cortarDim(int col, int lin)
    {
        var x = Mathf.RoundToInt(dimensions.x);
        var y = Mathf.RoundToInt(dimensions.y);
        Color[] arraycor = texturas.GetPixels(col*x,lin*y,x,y);//retorna um array com as texturas calculadas pela dimensão recortada

        Texture2D texturaauxiliar = new Texture2D(x,y);
        texturaauxiliar.SetPixels(arraycor);//define os pixels obtidos na textura auxiliar
        texturaauxiliar.Apply();//aplica os pixels
        return texturaauxiliar;//então, retorna a parte de pixels da imagem, recortada
    }
    private void sortPositions()
    {
        dispecas = new Vector2(dimensions.x/100f,dimensions.y/100f);
        for(int i=0;i<qtdepecas;i++)
        {
            for(int j=0;j<qtdepecas;j++)
            {
                posicao.Add(new Vector2(x*dispecas.x,y*dispecas.y));
            }
        }
    }
}
