Televisao tv = new Televisao(42);
tv.Ligar();

tv.EscolherCanal(1);
tv.AumentarVolume();
Console.WriteLine("teste");
Console.WriteLine(tv.canalAtual);
Console.WriteLine();

tv.AtivarMudo();
tv.DesativarMudo();
Console.WriteLine("Desativando mudo");
Console.WriteLine(tv.volume);
Console.WriteLine();


tv.AumentarCanal();
tv.DiminuirCanal();
tv.Desligar();
