using System; 
using System.Collections.Generic; 


public class Pessoa {
    public string Nome; 
    public DateTime Nacimento; 
    public string Cidade; 

}


public class TreinofocadoC {

    public string SeparaLetras (string frase)
    {
        string nova = string.Empty; 
        for (int i = 0; i < frase.Length; i++)
        {
            char letra = frase[i];
            nova = nova + letra + "-";  
        }
        return nova;

    }
    
    public string inverter (string frase)
    {
        string nova = string.Empty; 
        for (int i = 0; i < frase.Length; i++)
        {
            char letra = frase [i];
            nova = letra + nova; 
        }
        return nova; 
    }

    public string TodasVogais (string frase)
    {
        
             
                string m  = ""; 
                if (frase.Contains('a') || frase.Contains('e') || frase.Contains('i') || frase.Contains('o') || frase.Contains('u') )
                {
                 string nova = string.Empty; 
                 for (int i = 0; i < frase.Length; i++)
                {
                 char letra = frase [i];
                 nova = letra + nova;  
                } 
                }
                

                else
                {
                m = "Não tem vogais"; 
                }
                 
            
                
        
        return m; 

        
        

    }

}



TreinofocadoC Tc = new TreinofocadoC (); 

/// Separar Letras
string Separa = Tc.SeparaLetras ("Mateus"); 
Console.WriteLine(Separa); 


/// Inverter Frase
string inverter = Tc.inverter ("Mateus Eustáquio Marques de Macedo"); 
Console.WriteLine(inverter); 

/// Contêm vogais

string verificar = Tc.TodasVogais ("oiie"); 
Console.WriteLine(verificar); 




