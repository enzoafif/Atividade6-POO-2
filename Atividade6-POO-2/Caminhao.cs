using Atividade6_POO_2;

class Caminhao : Veiculo
{
    float _capacidadeCarga;

    public Caminhao(string marca, string modelo, string placa, int ano, float precoDiaria, float capacidadeCarga) : base(marca, modelo, placa, ano, precoDiaria)
    {
        _capacidadeCarga = capacidadeCarga;
    }

    public string MostrarCarga()
    {
        return $"Capacidade de Carga: {_capacidadeCarga} toneladas";
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $", {MostrarCarga()}";
    }
}
