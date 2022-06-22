using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
   public class Login
    {
        protected string usuario { get; set; }
        protected string senha { get; set; }
        protected string novasenha { get; set; }

        public Login(string _usuario, string _senha, string _novasenha){

         this.usuario = _usuario;
         this.senha = _senha;
         this.novasenha = _novasenha;
         CriacaoConta();  
         AlterarSenha();
         EntrarnoSistema();
       } 

       public  void  CriacaoConta(){
       Console.WriteLine("Digite seu usuário e senha: \n" + usuario + "\n" + senha);
      }
       
       public  void AlterarSenha(){
       Console.WriteLine("Digite sua nova senha: " + novasenha);
      }

      public void EntrarnoSistema(){
      if(this.usuario == usuario && this.senha == senha){
         Console.WriteLine("Bem vindo ao sistema!");
         
         Console.WriteLine("\n");
        }
      else if(this.usuario == usuario && this.senha != senha){
        Console.WriteLine("Senha incorreta!");
      }
      else {
        Console.WriteLine("Este usuário não existe!");
      }
    }

    }
}
