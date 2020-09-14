using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa Pedro = new Pessoa();
    Pedro.setIdade(3);
    Pedro.setNome("Pedro");
    Pedro.setpeso(43);
    Pedro.setAltura(1.72);
    Console.WriteLine($"Seu nome é >> {Pedro.getnome()}  \nSua Idade >> {Pedro.getidade()} \nSua Altura >> {Pedro.getaltura()}\nSeu Peso >> {Pedro.getpeso()}"); 
     
  }
}