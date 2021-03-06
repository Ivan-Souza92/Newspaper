using System;
using System.Collections.Generic;

namespace DIO.News
{
    class Program
    {
		static List<Noticias> listNoticias = new List<Noticias>();
		static void Main(string[] args)
        {
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						InserirNoticia();
						break;
					case "2":
						ListarNoticias();
						break;
					case "3":
						ExcluirNoticia();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por ler as nossas noticias !!");
			Console.ReadLine();

		}

		private static void InserirNoticia()
		{
			Console.WriteLine("Inserir Uma Nova Notícia");

			Console.Write("Titulo da Notícia: ");
			string tituloNoticia = Console.ReadLine();

			Console.Write("Autor da Notícia: ");
			string autorNoticia = Console.ReadLine();

			Console.Write("Insira á Notícia ");
			string noticiaText = Console.ReadLine();

			Noticias novaNoticia = new Noticias(titulo: tituloNoticia, autor: autorNoticia, noticia: noticiaText);

			listNoticias.Add(novaNoticia);
		}

		private static void ListarNoticias()
		{
			Console.WriteLine("Listar Noticias");

			if (listNoticias.Count == 0)
			{
				Console.WriteLine("Nenhuma Notícia cadastrada.");
				return;
			}

			for (int i = 0; i < listNoticias.Count; i++)
			{
				Noticias noticia = listNoticias[i];
				Console.Write("\n{0} - ", i);
				Console.WriteLine(noticia);

				Console.WriteLine("=====================================");
			}
		}

		private static void ExcluirNoticia()
        {
			
			Console.WriteLine("Excluir Noticia");

			if (listNoticias.Count == 0)
			{
				Console.WriteLine("Nenhuma Notícia cadastrada.");
				return;
			}

			Console.WriteLine("Digite o número da noticia que deseja excluir");
			int j = int.Parse(Console.ReadLine());

			listNoticias.RemoveAt(j);
			Console.WriteLine("Noticia removida com sucesso");

		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Jornal Regional ");
			Console.WriteLine("Informe a opção desejada: ");

			Console.WriteLine("1- Inserir Notícias");
			Console.WriteLine("2- Listar Notícias");
			Console.WriteLine("3- Excluir Notícias");
			Console.WriteLine("X- Sair");
			Console.WriteLine();
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
