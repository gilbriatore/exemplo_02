using System.Collections.Generic;
class Pessoa {

  private string nome;
  public string Cpf { get; set; }
  private string sexo;
  private string telefone;

  public List<Endereco> Enderecos { get; set; }

  public string getNome(){
    return nome;
  }
  public void setNome(string nome){
    this.nome = nome;
  }
}