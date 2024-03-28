using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class calculadora : MonoBehaviour {

    public Text resultado;
    public Text lblTempo;
    public Text operacion;
    private string textoimprimir;
    string valor1;
    string valor2;
    string operacionActual;
    double rta;
    double memoria = 0;

    public void BorrarC()
    {

        resultado.text = "0";
        lblTempo.text = "";
        operacion.text = "";
    }

    public void sumas()
    {
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
            memoria += double.Parse(resultado.text);
        }
    }
    public void memoryless()
    {
        if (resultado.text != "")
        {
            memoria -= double.Parse(resultado.text);
        }
    }
    public void memoryclear()
    {
        memoria = 0;
    }
    public void bin()
    {
        resultado.text = memoria.ToString();
    }


    public void memoryresult()
    {
        if (resultado.text != "")
        {
            operacion.text = "mod";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
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
            case "retroceso":
                respuesta = (System.Math.Sqrt(double.Parse(n1))).ToString();
                break;
            case "po2":
                respuesta = (System.Math.Pow(double.Parse(n1), 2)).ToString();
                break;
            case "pox":
                respuesta = (System.Math.Pow(double.Parse(n1), double.Parse(n2))).ToString();
                break;
            case "mod":
                respuesta = (double.Parse(n1) % double.Parse(n2)).ToString();
                break;
            case "bin":
                int numeroDecimal = int.Parse(n1);
                int exp, digito;
                double binario;
                exp = 0;
                binario = 0;
                while (numeroDecimal != 0)
                {
                    digito = numeroDecimal % 2;
                    binario = binario + digito * System.Math.Pow(10, exp);
                    exp++;
                    numeroDecimal = numeroDecimal / 2;
                }

                respuesta = binario.ToString();
                break;
            case "dec":
                int dec=0;
                int exponente = 0;
                int numero = int.Parse(n1);
                while (numero != 0)
                    {
                        digito = numero % 10;
                        dec = dec + digito * (int)System.Math.Pow(2, exponente);
                        exponente++;
                        numero = numero / 10;
                    }
                respuesta = dec.ToString();
                break;
            case "log":
                respuesta = (System.Math.Log10(double.Parse(n1))).ToString();
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
        
        return respuesta;
    }
}
