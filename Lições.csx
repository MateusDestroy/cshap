using System;
using System.Collections.Generic;


public class Retangulo {
    public double Base   {get; set;} 
    public double Altura {get; set;} 
}

public class Notas {

    public double Nota1 {get; set;} 
    public double Nota2 {get; set;} 
    public double Nota3 {get; set;} 
}



public class TreinoFocadoA {

public List <int> GerarSequencia (int fim){
List<int> Seq = new List<int>(); 
for (int i = 1; i <= fim; i++)
{  	
Seq.Add(i);  

}
return Seq; 
}

public List <int> GerarSequencia2 (int inicio, int fim){
List<int> Seq = new List<int>(); 
for (int i = inicio; i <= fim; i++)
{  	
Seq.Add(i);  

}
return Seq; 
}

public List <int> GerarSequenciaPares (int fim){

List<int> Seq = new List<int>(); 
for (int i = 0; i <= fim; i += 2)
{  	
     
Seq.Add(i);  

}
return Seq; 

}



public int SomarNumeros(int fim){

int somar = 0; 

for (int i = 0; i <= fim; i++) {

somar += i; 

}
return somar; 

}


public double CalcularMedia (List <double> media)
{
    double soma = 0; 
    for (int i = 0; i < media.Count; i++)
    {
        soma += media[i]; 
    }
    double m = soma / media.Count; 
    return m; 
}



public List <double> CalcularMedias ( List <Notas> alunos)
{
    List<double> Media = new List<double>(); 

    for (int i = 0; i < alunos.Count; i++)
    {
        Notas notasAluno = alunos[i]; 
        double media = (notasAluno.Nota1 + notasAluno.Nota2 + notasAluno.Nota3) / 3; 
        Media.Add(media); 
    }
  
    return Media; 

}


public List <double> CalcularQuadrados (List<double> numeros) 
{
    List<double> Total = new List<double>();

        for (int i = 0; i < numeros.Count; i++)
        {
            
            double valor = numeros[i]; 
            double Potencia = Math.Pow (valor, 2); 

            Total.Add(Potencia); 

        }
    
    return Total; 
}



private double AreaRetangulo (Retangulo V)
{
   
  return V.Base * V.Altura; 
   
}


public List<double> AreaRetangulos (List <Retangulo> retangulos)
{
    List <double> ValorRet = new  List<double>(); 
   
     for (int i = 0; i < retangulos.Count; i++)     
    {
            
        Retangulo V = retangulos[i]; 
        double area = AreaRetangulo(V);

        ValorRet.Add(area); 

    }


  return ValorRet;

}

}


TreinoFocadoA T = new TreinoFocadoA(); 


/// Gerar Sequencia

List <int> Seq = T.GerarSequencia(10);
Console.WriteLine(String.Join( "-", Seq)); 


/// Gerar Sequencia INICIO e FIM

List <int> Seq2 = T.GerarSequencia2 (10, 16); 
Console.WriteLine(String.Join("-", Seq2)); 


/// Gerar Sequncia Pares

List <int> Seq3 = T.GerarSequenciaPares(16); 
Console.WriteLine(String.Join("-", Seq3));



/// Somar Numeros

int soma = T.SomarNumeros(5); 
Console.WriteLine(soma); 



/// Calcular Media

List<double> n = new List<double>(); 
n.Add(6); 
n.Add(8); 
n.Add(4); 
n.Add(10); 

double Resultado = T.CalcularMedia(n); 
Console.WriteLine("O valor da Media é " + Resultado); 




/// Calcular Medias

Notas Aluno1 =  new Notas(); 
Aluno1.Nota1 = 10; 
Aluno1.Nota2 = 7; 
Aluno1.Nota3  = 4; 


Notas Aluno2 = new Notas(); 
Aluno2.Nota1 = 5; 
Aluno2.Nota2 = 5; 
Aluno2.Nota3 = 5; 

Notas Aluno3 = new Notas(); 
Aluno3.Nota1 = 10; 
Aluno3.Nota2 = 10; 
Aluno3.Nota3 = 10; 


List<Notas> b = new List<Notas>(); 
b.Add(Aluno1); 
b.Add(Aluno2); 
b.Add(Aluno3); 

List <double> ValordeNotas = T.CalcularMedias(b); 
Console.WriteLine(String.Join("-" , ValordeNotas)); 




// CalcularQuadrados

List<double> Q1 = new List<double>(); 
Q1.Add(2);
Q1.Add(3); 
Q1.Add(4); 


List <double> ValorQuadrados = T.CalcularQuadrados(Q1); 
Console.WriteLine(String.Join("-", ValorQuadrados)); 



// Calcular Area dos Retangulos 


Retangulo Ret1 = new Retangulo(); 
Ret1.Base   = 4; 
Ret1.Altura = 5; 

Retangulo Ret2 = new Retangulo(); 
Ret2.Base   = 4; 
Ret2.Altura = 10; 

Retangulo Ret3 = new Retangulo(); 
Ret3.Base   = 4; 
Ret3.Altura = 12; 


List<Retangulo> Valor = new List<Retangulo> (); 
Valor.Add(Ret1); 
Valor.Add(Ret2);
Valor.Add(Ret3); 

List <double> ValorRetangulos = T.AreaRetangulos(Valor); 
Console.WriteLine(String.Join("-", ValorRetangulos)); 















