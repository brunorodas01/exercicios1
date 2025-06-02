int quantospães, quantasbroas;
decimal Qpães, Qbroas, valorarrecadado, valorguardado;
Console.WriteLine("Digite o total de pão vendido");
quantospães = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o total de broas vendidas");
quantasbroas = Convert.ToInt32(Console.ReadLine());

Qpães = quantospães * 0.12m;
Qbroas = quantasbroas * 1.50m;

valorarrecadado = Qpães + Qbroas;

valorguardado = valorarrecadado * 0.10m;

Console.WriteLine("valorarrecadado : "+valorguardado);
Console.WriteLine("O valorguardado na poupança (10%)R$" + valorguardado);


