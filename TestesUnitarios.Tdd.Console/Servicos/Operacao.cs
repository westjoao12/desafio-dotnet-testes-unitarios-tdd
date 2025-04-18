namespace TestesUnitarios.Tdd.Console{
    public class Operacao
    {
        public Operacao()
        {
            Tabela = [];
        }
        string _result=string.Empty;
        List<int> Tabela;
        public List<int> TabelaMultiplicar(int valor){
  
            for (int i = 1; i <= 12; i++)
            {
                Tabela.Add(valor * i);
            }
            return Tabela;
        }

        public string ExibirTabuadaMultiplicacao(int valor){
  
            for (int i = 1; i <= 12; i++)
            {
                _result += $"{valor} x {i} = {valor * i}\n";
            }
            return _result;
        }
    }
}