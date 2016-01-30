using UnityEngine;
using System.Collections;

public class ManagerSolucion : MonoBehaviour {

    static Random rnd = new Random();

    private string[] nervioso = {"nunca me pongo nervioso", "todos los hombres mueren", "solo cuando es inevitable"};
    public string nerviosoSol;

    private string[] chofer = { "Paco", "Max Power", "No lo se" };
    public string choferSol;

    private string[] tabaco = {"malboro","lucky strike","camel"};
    public string tabacoSol;

    private string[] nCig = { "me fumo 3", "solo 5", "una cajetilla"};
    public string nCigSol;

    private string[] cafe = { "solo", "con leche" };
    public string cafeSol;

    private string[] pelo = { "3 rubias", "2 pelirojas" };
    public string peloSol;

    private string[] secretaria = { "Maria", "Marta" , "Mary", "Marie"};
    public string secretariaSol;

    private string[] nPass = { "1", "3", "5", "6", "7", "8","9" };
    public string nPassSol;

    public string antesDe;

    public string primerLugar;//<--ESTA TIENE QUE EDITARSE EN EL JSON
    public string segundoLugar;
    public string tercerLugar;

    //Orden
    private string[] ordenPosibilidades = { "BOE","BEO","OBE","IOE","IEO","OIE","OEI",
                                            "IBE","BIE","BEI","IBO","BIO","BOI","OBI"};
    public string orden;


    // Use this for initialization
    void Start () {

        //Establecemos el orden
        orden = ordenPosibilidades[(int)Random.Range(0.0F, ordenPosibilidades.Length - 1)];

        //Establecemos el resto de variables
        nerviosoSol = nervioso[(int)Random.Range(0.0F, nervioso.Length-1)];
        choferSol = chofer[(int)Random.Range(0.0F, chofer.Length - 1)];
        tabacoSol = tabaco[(int)Random.Range(0.0F, tabaco.Length - 1)];
        nCigSol = nCig[(int)Random.Range(0.0F, nCig.Length - 1)];
        cafeSol = cafe[(int)Random.Range(0.0F, cafe.Length - 1)];
        peloSol = pelo[(int)Random.Range(0.0F, pelo.Length - 1)];
        secretariaSol = secretaria[(int)Random.Range(0.0F, secretaria.Length - 1)];
        nPassSol = nPass[(int)Random.Range(0.0F, nPass.Length - 1)];

        //Pistas del orden

        char[] sitios = orden.ToCharArray();

        //Miramos el tercer sitio
        if (sitios[2] == 'E')
        {
            tercerLugar = "Estanco";
        }
        else if (sitios[2] == 'I')
        {
            tercerLugar = "Iglesia";
        }
        else if (sitios[2] == 'O')
        {
            tercerLugar = "Oficina";
        }

        //Miramos el segundo sitio
        if (sitios[1] == 'B')
        {
            segundoLugar = "Bar";
            antesDe = tercerLugar;
        }
        else if (sitios[1] == 'I')
        {
            segundoLugar = "Iglesia";
        }
        else if (sitios[1] == 'O')
        {
            segundoLugar = "Oficina";
        }
        else if (sitios[1] == 'E')
        {
            segundoLugar = "Estanco";
        }

        //Miramos el primer sitio
        if (sitios[0] == 'B'){
            primerLugar = "Bar";
            antesDe = segundoLugar;
        }
        else if(sitios[0] == 'I')
        {
            primerLugar = "Iglesia";
        }
        else if (sitios[0] == 'O'){
            primerLugar = "Oficina";
        }

        Debug.Log(nerviosoSol);
        Debug.Log(choferSol);
        Debug.Log(tabacoSol);
        Debug.Log(orden);
        Debug.Log(primerLugar);
        Debug.Log(segundoLugar);
        Debug.Log(tercerLugar);
        Debug.Log(antesDe);


    }

    // Update is called once per frame
    void Update () {
        
	}
}