using TestesUnitarios.Tdd.Console;

Operacao operacao = new Operacao();

//Console.WriteLine($"{operacao.TabuadaMultiplicar(2)}");
List<int> tb = operacao.TabelaMultiplicar(2);

tb.ForEach(x => Console.WriteLine($"{x}"));