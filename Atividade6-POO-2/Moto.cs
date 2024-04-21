using Atividade6_POO_2;

class Moto : Veiculo
{
    int _cilindradas;

    public Moto(string marca, string modelo, string placa, int ano, float precoDiaria, int cilindradas) : base(marca, modelo, placa, ano, precoDiaria)
    {
        _cilindradas = cilindradas;
    }

    public string MostrarCilindradas()
    {
        return $"Cilindradas: {_cilindradas}";
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $", {MostrarCilindradas()}";
    }
}