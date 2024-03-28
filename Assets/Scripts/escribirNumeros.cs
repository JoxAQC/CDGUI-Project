using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class escribirNumeros : MonoBehaviour {

    private string textoimprimir;
    public Text resultado;

    public void reemplazar0()
    {
        if (resultado.text == "0")
        {
            resultado.text = "";
        }
    }
    public void colocar0()
    {
        reemplazar0();
        textoimprimir = "0";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar1()
    {
        reemplazar0();
        textoimprimir = "1";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar2()
    {
        reemplazar0();
        textoimprimir = "2";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar3()
    {
        reemplazar0();
        textoimprimir = "3";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar4()
    {
        reemplazar0();
        textoimprimir = "4";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar5()
    {
        reemplazar0();
        textoimprimir = "5";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar6()
    {
        reemplazar0();
        textoimprimir = "6";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar7()
    {
        reemplazar0();
        textoimprimir = "7";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar8()
    {
        reemplazar0();
        textoimprimir = "8";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar9()
    {
        reemplazar0();
        textoimprimir = "9";
        resultado.text = resultado.text + textoimprimir;
    }
    

    // Use this for initialization
    void Start () {
        resultado.text = "0";
	}
	
	// Update is called once per frame
	void Update () {

	}
}
