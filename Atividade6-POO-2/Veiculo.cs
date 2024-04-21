namespace Atividade6_POO_2
{
    public class Veiculo
    {
        public string _marca;
        public string _modelo;
        public string _placa;
        public int _ano;
        public float _precoDiaria;

        public Veiculo(string marca, string modelo, string placa, int ano, float precoDiaria)
        {
            _marca = marca;
            _modelo = modelo;
            _placa = placa;
            _ano = ano;
            _precoDiaria = precoDiaria;
        }

        public virtual string Mostrar()
        {
            return $"Veículo {_marca}, {_modelo}, Ano: {_ano}, Preço da diária, R${_precoDiaria}";
        }
    }

}
