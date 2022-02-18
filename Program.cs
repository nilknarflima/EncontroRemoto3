using System;

namespace Encontroremoto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Endereco end = new Endereco();
            end.logradouro = "Rua Hassenclever Santana";
            end.numero = 61;
            end.Bairro = "Santo Antonio";
            end.complemento = "Proximo à Politec";
            end.enderecoComercial = false;
            end.Cidade = "Manaus";


            pessoaFisica novaPf = new pessoaFisica();

            novaPf.endereco = end;
            novaPf.cpf = "72496517220";
            novaPf.dataNascimento = new DateTime(1982, 04, 17);
            novaPf.nome = "Franklin Souza Lima";


            pessoaFisica pf = new pessoaFisica();
            // pf.ValidarDataNascimento(pf.dataNascimento);

            bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);
            Console.WriteLine(idadeValida);
            if (idadeValida == true) {
                Console.WriteLine($"Cadastro Aprovado");

            }else{
                Console.WriteLine("$Cadastro Não Aprovado");
            }

            /*Console.WriteLine(novaPf.endereco.logradouro);
             Console.WriteLine(novaPf.endereco.numero);
              Console.WriteLine(novaPf.endereco.complemento);
               Console.WriteLine(novaPf.endereco.enderecoComercial);*/


               //(MÉTODO DE INTERPOLAÇÃO)
            //Console.WriteLine($"Rua: {novaPf.endereco.logradouro},{novaPf.endereco.numero}, {novaPf.endereco.complemento}");


         /*

            // ( METODO DE CONCATENAÇÃO )
            Console.WriteLine("Nome: " + novaPf.nome);
            Console.WriteLine("Endereço: " + novaPf.endereco.logradouro +  " , " +  "Nº " + novaPf.endereco.numero + " , " + "Bairro: " + novaPf.endereco.Bairro); 
*/

            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novapj = new PessoaJuridica();

             Endereco end = new Endereco();
            end.logradouro = "Rua Hassenclever Santana";
            end.numero = 61;
            end.Bairro = "Santo Antonio";
            end.complemento = "Proximo à Politec";
            end.Cidade = "Manaus";
            end.enderecoComercial = false;
           

        }
    }
}