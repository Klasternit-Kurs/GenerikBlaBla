using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenerikBlaBla
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> listaBrojeva;
			List<string> listaTxt;

			Zamenjivac<int> zam = new Zamenjivac<int>();
			zam.Zameni(5, 6);

			Zamenjivac<string> zam2 = new Zamenjivac<string>();
			zam2.Zameni("asd", "qwe");

			NasaLista<string> lst = new NasaLista<string>();
			lst.Dodaj("asd");
			lst.Dodaj("--");
			lst.Dodaj("grg");
			lst.Dodaj("s--f-");

			

			for (int brojac = 0; brojac < 20; brojac++)
				Console.WriteLine(lst.Sledeci());
			Console.ReadKey();

		}
	}

	class NasaLista<T>
	{
		private T[] niz = new T[0];

		private int trenutniIndeks = 0;

		public void Dodaj(T nesto)
		{
			Array.Resize<T>(ref niz, niz.Length + 1);
			niz[niz.Length - 1] = nesto;
		}

		public T Sledeci()
		{
			if (niz.Length == 0)
				return default(T);
			if (trenutniIndeks == niz.Length)
				trenutniIndeks = 0;

			return niz[trenutniIndeks++];
		}
	}

	class Zamenjivac<KoZnaSta>
	{
		public void Zameni(KoZnaSta x, KoZnaSta y)
		{
			KoZnaSta temp = x;
			x = y;
			y = temp;
		}
	}
}
