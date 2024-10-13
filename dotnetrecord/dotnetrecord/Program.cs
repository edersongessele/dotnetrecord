

var usuario1 = new Usuario("teste", "teste@gmail.com");
var usuario2 = new Usuario("teste", "teste@gmail.com");

Console.WriteLine($"Usuario1 => {usuario1}");
Console.WriteLine($"Usuario2 => {usuario2}");
Console.WriteLine($"Usuario 1 é igual ao Usurio 2 => {usuario1 == usuario2}");
Console.WriteLine($"Sao iguais => {usuario1.Equals(usuario2)}");

var usuario3 = usuario1 with { nome = "teste2" };

Console.WriteLine($"Usuario3 => {usuario3}");

record Usuario(string nome, string email);