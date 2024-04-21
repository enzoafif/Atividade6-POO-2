using Atividade6_POO_2;

class Carro : Veiculo
{
    int _numeroPortas;

    public Carro(string marca, string modelo, string placa, int ano, float precoDiaria, int numeroPortas) : base(marca, modelo, placa, ano, precoDiaria)
    {
        _numeroPortas = numeroPortas;
    }

    public string MostrarNumeroDePortas()
    {
        return $"Número de Portas: {_numeroPortas}";
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $", {MostrarNumeroDePortas()}";
    }
}