using System;
using System.Windows.Forms;

public static class Validacoes
{
   
    public static bool ValidaCPF(string cpf)
    {
        int soma = 0;
        int resto = 0;
        int resto2 = 0;
        
        
        //Multiplicador dos digitos verificados
        int verifica1 = 10;
        int verifica2 =11;

        cpf = cpf.Replace("." , "");
        cpf = cpf.Replace("-", "");
        
        
        if(cpf.Length != 11) { return false; }

        
        for (int i = 0; i < 9; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * verifica1;
            verifica1--;
        }
    
        
        
        if (soma % 11 < 2)
        {
           resto = 0;
        } else
        {
            resto = 11 - (soma % 11);
        }

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * verifica2;
            verifica2--;
        }

        if (soma % 11 < 2)
        {
            resto2 = 0;
        }
        else
        {
            resto2 = 11 - (soma % 11);
        }
        if (resto == Convert.ToInt32(cpf[9].ToString()) && resto2 == Convert.ToInt32(cpf[10].ToString()))
        {
            return true; 
        }
        else
        {
            return false;
        }
    }
}