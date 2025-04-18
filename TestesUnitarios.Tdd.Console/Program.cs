using TestesUnitarios.Tdd.Console;

Operacao operacao = new Operacao();


List<int> tb = operacao.TabelaMultiplicar(2);


Console.WriteLine("Tabuada:\n");
Console.WriteLine($"{operacao.ExibirTabuadaMultiplicacao(2)}");

Console.WriteLine("\nResultados da multiplicação:\n");
tb.ForEach(x => Console.WriteLine($"{x}"));
