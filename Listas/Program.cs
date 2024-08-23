List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MS");
listaString.Add("RJ");

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("MG");

System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


//Console.WriteLine("Percorrendo a Lista com o FOR");
//for (int contador = 0; contador < listaString.Count; contador++)
//{
//    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
//}
//Console.WriteLine();
//Console.WriteLine("Percorrendo a Lista com o Foreach");
//int i = 0;
//foreach (string str in listaString)
//{
//    Console.WriteLine($"Posição N° {i} - {str}");
//    i++;
//}