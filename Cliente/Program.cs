// See https://aka.ms/new-console-template for more information
using Cliente;
using Mediador;
using Mediador.Contracts;

Console.WriteLine("Hello, World!");

Dictionary<string, string> data = new Dictionary<string, string>()
{
    {"string", "qwert"},
    {"codigo", "1"}
};

IFachada fachada = new Fachada();
ClaseCliente cliente1 = new ClaseCliente("admin", "juan", "juan123", fachada);
cliente1.ordenEnLinea(data);