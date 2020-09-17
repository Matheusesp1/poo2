using System;
namespace lojinha
{
    public class estoque : loja
    {
        public string produto
        {
            get;
            set;
        }
        
        public int quantidade_produto
            {
            get;
            set;
        }
         
          public string fornecedor
        {
            get;
            set;
        }
           
         private int contador = (for (int i = 0; i < length; i++)
         {
             
         });
        
         produto P

        public override string ToString()
        {
            return produto + "\t" + quantidade_produto +  "\t" + fornecedor;
        }
        public void Resumo(){

          foreach( var produto in estoque)
           {
               Console.WriteLine();
           }

        }
          

    }


}