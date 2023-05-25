public class Calcular
{
    public double peso { get; set; }
    public double altura { get; set; }

    public string nome { get; set; }
    public string cpf { get; set; }
    public string idade { get; set; }
    public string sexo { get; set; }

    public Calcular(string nome, string cpf, string idade, double peso, double altura, string sexo)
    {
        this.altura = altura;
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.peso = peso;
        this.sexo = sexo;
        
    }
    //IMc 
    public (double, string, string) Imc()
    {
       
        double imc = (  peso / (altura * altura)  );
         

        if (imc <  18.5)
        {
            return (imc," Magreza   ", "0");
        } 
        else if (imc > 18.5 && imc < 24.99)
        {
            return (imc, " Normal    ", "0");
        } 
        else if (imc > 25 && imc < 29.99)
        {
            return (imc, "  Sobrepeso", "   I");
        } 
        else if (imc > 30 && imc < 39.99)
        {
            return (imc, "  Obesidade", "   II");
        } 
        else
        {
            return (imc, "  Obesidade Grave ", "   III");
        }
    }
}