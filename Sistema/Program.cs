// See https://aka.ms/new-console-template for more information
using Sistema;

Dictionary<string, string> data = new Dictionary<string, string>()
{
    {"string", "qwert"},
    {"codigo", "1"}
};

Ordenes ordenes = new Ordenes();
PartesSistema sistema = new PartesSistema(ordenes);

sistema.solicitudSistema(data);