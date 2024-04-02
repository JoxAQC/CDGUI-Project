using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class calculadora : MonoBehaviour {

    public Text resultado;
    public Text lblTempo;
    public Text operacion;
    public Text memoria;
    public Image imagen;
    private string textoimprimir;
    string valor1;
    string valor2;
    string operacionActual;
    double rta;

    public void op_parcial()
    {
        if(operacion.text != "")
        {
            igual();
        }
    }
    public void BorrarC()
    {
        resultado.text = "0";
        lblTempo.text = "";
        operacion.text = "";
    }

    public void sumas()
    {
        op_parcial();
        if(resultado.text != "")
        {
            operacion.text = "+";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
        
    }
    public void resta()
    {
        op_parcial();
        if (resultado.text != "")
        {
            operacion.text = "-";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void multiplicacion()
    {
        op_parcial();
        if (resultado.text != "")
        {
            operacion.text = "*";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void division()
    {
        op_parcial();
        if (resultado.text != "")
        {
            operacion.text = "/";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }

    public void deci()
    {
        if (!resultado.text.Contains("."))
        {
            resultado.text += ".";
        }
    }
    public void retroceso()
    {
        if (resultado.text.Length > 1)
        {
            resultado.text = resultado.text.Substring(0, resultado.text.Length - 1);
        }
        else if (resultado.text.Length == 1)
        {
            resultado.text = "0";
        }
    }

    public void memoryplus()
    {
        if (resultado.text != "")
        {
            valor1 = memoria.text;
            valor2 = resultado.text;
            memoria.text = operaciones(valor1, valor2, "+");
            resultado.text = memoria.text;
        }
    }
    public void memoryless()
    {
        if (resultado.text != "")
        {
            valor1 = memoria.text;
            valor2 = resultado.text;
            memoria.text = operaciones(valor1, valor2, "-");
            resultado.text = memoria.text;
        }
    }
    public void memoryclear()
    {
        memoria.text = "0";
    }
    public void memoryresult()
    {
        resultado.text = memoria.text;
    }
    public void igual()
    {
        if (resultado.text != "")
        {
            valor2 = resultado.text;
            valor1 = lblTempo.text;
            operacionActual = operacion.text;
            resultado.text = operaciones(valor1, valor2, operacionActual);
        }
    }
    public string operaciones(string n1, string n2, string opeMath)
    {
        string respuesta = "";
        switch (opeMath)
        {
            case "+":
                respuesta = (double.Parse(n1) + double.Parse(n2)).ToString();
                break;
            case "-":
                respuesta = (double.Parse(n1) - double.Parse(n2)).ToString();
                break;
            case "*":
                respuesta = (double.Parse(n1) * double.Parse(n2)).ToString();
                break;
            case "/":
                if (!n2.Equals("0"))
                {
                    respuesta = (double.Parse(n1) / double.Parse(n2)).ToString();
                } else
                {
                    respuesta = "La division por 0 no es posible";
                }
                
                break;
        }

        // Redondear decimales si es necesario
        double resultadoNumerico;
        if (double.TryParse(respuesta, out resultadoNumerico))
        {
            if (resultadoNumerico == (int)resultadoNumerico) // Si es un número entero
                respuesta = resultadoNumerico.ToString("F0"); // Mostrar sin decimales
            else
                respuesta = resultadoNumerico.ToString("F5"); // Mostrar con 5 decimales
        }

        memoria.text = respuesta;
        return respuesta;
    }
    void Start()
    {
        memoria.text = "0";
    }
    void Update()
    {
        if (memoria.text != "0")
        {
            imagen.color = Color.green;
        } else
        {
            imagen.color = Color.red;
        }
    }
}
