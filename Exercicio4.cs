/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/
class Pessoa{
  private string nome;
  private double peso, idade, altura;
  
  //Metodos

  // set
  public void setNome(string nomi){
    nome = nomi;
  }
  public void setIdade(double numero){
    idade = numero;
  }
  public void setpeso(double massa){
    peso = massa;
  }
  public void setAltura(double tamanho){
    altura = tamanho;
  }
  // get
  public string getnome(){
    return nome;
  }
  public double getidade(){
    return idade;
  }
  public double getaltura(){
    return altura;
  }
  public double getpeso(){
    return peso;
  }
  // Métodos: Envelhercer, engordar, emagrecer, crescer
  public double envelhecer(double anosenvelhecidos){
    idade += anosenvelhecidos;
    return idade;
  }
  public double engordar(double gordo){
    peso += gordo;
    return peso;
  }
  public double emagrecer(double magro){
    peso -= magro;
    return peso;
  }
  public double crescer(double aumento){
    if(idade<21){
      altura += 0.5;
      }
    else {
      altura+=aumento;
    }
    return altura;
  }
  
}

