using DelegatesEvents;

var lista = new Lista();

lista.Notificar += Notificar;
lista.Notificar += NotificarNovamente;
lista.Add("A");
lista.Add("B");
lista.Add("C");

Action<Lista> action = new Action<Lista>(i => Console.WriteLine(i));
Func<Lista, bool> func = new Func<Lista, bool>(i => i.Id == 1);
Predicate<Lista> pred = new Predicate<Lista>(i => i.Id == 3);

var exist = lista.ExistItem(pred);

Console.WriteLine(exist);


static void Notificar()
{
    Console.WriteLine("Fui notificado");
}

static void NotificarNovamente()
{
    Console.WriteLine("Fui notificado novamente");
}




















// var figura = new FiguraGeometrica()
// {
//     Altura = 10,
//     Largura = 10,
//     Profundidade = 10
// };

// figura.Calcular += CalcularAreaQuadrado;
// figura.Calcular += CalcularVolumeCubo;
// figura.EventHandler();

// static void CalcularAreaQuadrado(double altura, double largura, double profundidade)
// {
//     var area = altura * largura;
//     Console.WriteLine("Evento disparado da classe cliente, calculo de area quadrado");
//     Console.WriteLine(area);
// }

// static void CalcularVolumeCubo(double altura, double largura, double profundidade)
// {
//     var volume = altura * largura * profundidade;
//     Console.WriteLine("Evento disparado da classe cliente, calculo volume de um cubo");
//     Console.WriteLine(volume);
// }




