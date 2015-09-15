using UnityEngine;
using System.Collections;

public class ReturnTypes : MonoBehaviour
{
    void Start()
    {
        //Eerste funtie geef je 2 parametrs mee
        plus(1, 1);//hier uit komt 2

        //tweede functie geef je ook 2 parameters mee
        //Maar je krijgt wel een int terug
        //deze int stop je meteen in de debug.log en print je naar de console
        Debug.Log(plusReturn(2, 2));//hier uit komt 4
    }

    //_a + _b functie
    //deze functie returned void. Dus niets.
    //Hier heb je 2 parameters _a en _b.
    //deze moeten ingevuld worden als je de functie aan roept.
    private void plus(int _a, int _b)
    {
        int antwoord = _a + _b;//sla het antwoord tijdelijk op
        Debug.Log(antwoord);//print het antwoord
    }

    //_a + _b functie
    //deze functie returned een int!
    //return betekend dat je iets terug krijgt uit de functie.
    //in dit geval is het een int.
    private int plusReturn(int _a, int _b)
    {
        int antwoord = _a + _b;//sla het antwoord tijdelijk op
        return antwoord;//return het antwoord van deze functie(dus als het ware geef je dat terug aan de code die deze functie aan geroepen had)
    }
}
