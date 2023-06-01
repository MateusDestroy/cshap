using System;
using System.Collections.Generic;



//// EXERCICIO 2


public class Pessoa {
  public string   Nome         {get; set;}
  public DateTime Nacimento    {get; set;}

  public override string ToString ()
  {
      return "(" + Nome + "," + Nacimento.ToString() + ")"; 

  }
}



public class TreinoFocadoB {


    public List<DateTime> GerarSequenciaData (int qtd) {
           
            List<DateTime> Data = new List<DateTime>(); 

            DateTime hoje = DateTime.Now.Date;
            for (int i = 0; i < qtd; i++)
            {
                DateTime dt = hoje.AddDays(i);
             
                Data.Add(dt); 
            }
            return Data; 
    }



    public List<DateTime> GerarSequenciaData2 (DateTime data, int qtd){

        List<DateTime> proximo = new List<DateTime>(); 

        for(int i = 0; i < qtd; i++)
        {
            DateTime dt = data.AddDays(i); 
            proximo.Add(dt);
        }

        return proximo; 
    }


    public List<DateTime> GerarSequenciaDiaPares (int qtd) {

       List <DateTime> Pares = new List<DateTime>(); 

        for (int i = 0; i < qtd; i+=2)
        {
            DateTime hoje = new DateTime (2021, 06, 10); 
            DateTime dt = hoje.AddDays(i); 
            Pares.Add(dt); 
        }


       return Pares; 


    } 


   private string Signo (DateTime nacimento){
         
      DateTime Data1 = new DateTime (1989, 10, 22); 
      DateTime Data2 = new DateTime (1989, 10, 23 );
      string m = ""; 

      if (nacimento == Data1)
      {
        m = "Libra";  
      }

      else if (nacimento == Data2)
      {
        m = "Escorpião";  
      }
		
	  else 
	  {
		  m  = "Não pertence a nem um signo"; 
	  }

      return m ;  

    }

    public List <string> Signos (List <DateTime> nacimentos) {

     List<string> Data = new List<string> (); 

    for(int i = 0; i < nacimentos.Count; i++ )
     {
      DateTime v = nacimentos [i]; 
      string  Pessoas = Signo(v); 

      Data.Add(Pessoas); 

     }
      return Data;

    }
    

    public List <Pessoa> FiltraMaior18 (List <Pessoa> pessoas)
    {

     List <Pessoa> Datas = new List<Pessoa> (); 
     for (int i = 0; i < pessoas.Count; i++)
     {
         Pessoa p = pessoas[i]; 
       if (p.Nacimento <= DateTime.Now.AddYears(-18))
       {
           Datas.Add(p); 
       } 
      
    
     }
     return Datas; 

    }

    public bool TodosMaiores18 (List <Pessoa> pessoas)
    {
        bool x = true;
        for (int i = 0; i < pessoas.Count; i++)
        {
        Pessoa p = pessoas[i];

        if (p.Nacimento > DateTime.Now.AddYears(-18))
        { 
            x = false; 

        }
       
        }
         return x; 
    }




    }
 



    





TreinoFocadoB Tb = new TreinoFocadoB(); 


/// Proximo dia
List<DateTime> prox = Tb.GerarSequenciaData(2);
Console.WriteLine(String.Join(" - ", prox)); 



/// Dias
DateTime data = new DateTime (2003, 05, 15); 

List<DateTime> dias = Tb.GerarSequenciaData2(data, 2); 
Console.WriteLine(String.Join(" - ", dias));  


/// Dias Pares
List<DateTime> DiasPares = Tb.GerarSequenciaDiaPares(4); 
Console.WriteLine(String.Join(" - ", DiasPares)); 


/// Signos

DateTime Pessoa1 = new DateTime (1989, 10, 22);
DateTime Pessoa2 = new DateTime (1989, 10, 23);
DateTime Pessoa3 = new DateTime (1989, 10, 24);
List <DateTime> DatasSigno = new List<DateTime>();
DatasSigno.Add(Pessoa1);
DatasSigno.Add(Pessoa2);
DatasSigno.Add(Pessoa3);

List <string> Horóscopo  = Tb.Signos(DatasSigno);
Console.WriteLine(String.Join(" - ", Horóscopo));


/// Datas Pessoas

List <Pessoa> DatasPessoasMaior = new List<Pessoa>()
{
     new Pessoa () {Nome = "Mateus", Nacimento = new DateTime (2003, 05, 16)}, 
      new Pessoa () {Nome = "Jason", Nacimento = new DateTime (2000, 02, 17)},
       new Pessoa () {Nome = "Jesus", Nacimento = new DateTime (2001, 05, 13)},
        new Pessoa () {Nome = "Felipe", Nacimento = new DateTime (2002, 04, 18)},
         new Pessoa () {Nome = "João", Nacimento = new DateTime (1999, 08, 18)}

}; 

List<Pessoa> FiltrarPessoas = Tb.FiltraMaior18(DatasPessoasMaior); 
Console.WriteLine(String.Join("-", FiltrarPessoas));

/// Todos são de Maior? 


List <Pessoa> DatasPessoasFesta = new List<Pessoa>()
{
    new Pessoa () {Nome = "Mateus", Nacimento = new DateTime (2003, 05, 16)}, 
      new Pessoa () {Nome = "Jason", Nacimento = new DateTime (2000, 02, 17)},
       new Pessoa () {Nome = "Jesus", Nacimento = new DateTime (2001, 05, 13)},
        new Pessoa () {Nome = "Felipe", Nacimento = new DateTime (2003, 04, 18)},
         new Pessoa () {Nome = "João", Nacimento = new DateTime (1999, 08, 18)}
}; 


bool FiltrarMaiores = Tb.TodosMaiores18(DatasPessoasFesta);
Console.WriteLine(String.Join("-", FiltrarMaiores)); 






