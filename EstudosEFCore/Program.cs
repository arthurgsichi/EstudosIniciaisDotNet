// See https://aka.ms/new-console-template for more information
using EFCoreExample.Contexts;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

var DB = new AppDbContex();

/*
var cliente1 = new Cliente
{
    Nome = "Arthur Gutso Siki",
    Cpf = "123.123.123-12"
};
var cliente2 = new Cliente
{
    Nome = "The honored one",
    Cpf = "000.000.000-01"          serve para setar um cliente
};
var cliente3 = new Cliente
{
    Nome = "The lucky number",
    Cpf = "888.888.888-88"
};
DB.AddRange(cliente1, cliente2, cliente3);
DB.SaveChanges();


foreach (var cliente in DB.Clientes.ToList())
{                                         serve para buscar clientes no geral
    System.Console.WriteLine(cliente);
}


var cliente = DB.Clientes
    .Where(cliente => cliente.Nome.Contains("Arthur Gutso Siki"))
    .Select(x => x.Nome)        // busca um cliente apenas
    .Single();

System.Console.WriteLine(cliente);


var cliente = DB.Clientes.First();
cliente.Nome = "Arthur Falso";          // como alterar algo da tabela
DB.SaveChanges();


var cliente = new Cliente
{
    Id = 2,
    Nome = "o mais honrado ",
    Cpf = "123.123.123.12"
};                                  //reescrever algo da tabela sem necessariamente buscar na tabela
DB.Update(cliente);
//DB.Entry(cliente).State = EntityState.Modified;
DB.SaveChanges();

var cliente6 = new Cliente
{
   Nome = "Matheus eduardo de miles morales sousa",
    Cpf = "280.022.028-00"
};
DB.AddRange(cliente6);
DB.SaveChanges();
*/
var cliente6 = new Cliente {Id = 1};
DB.Remove(cliente6);
DB.SaveChanges();
