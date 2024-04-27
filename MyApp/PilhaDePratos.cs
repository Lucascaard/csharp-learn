namespace Acme.Collections;

public class PilhaDePratos<T>
{
	Entrada? prato;

	public void NovoPrato(T dados)
	{
		prato = new Entrada(prato, dados);
	}

	public T RetiraPrato()
	{
		if (prato == null)
		{
			throw new InvalidOperationException();
		}
		T result = prato.Dados;
		prato = prato.proximo;

		return result;
	}

	class Entrada
	{
		public Entrada proximo { get; set; }
		public T Dados { get; set; }

		public Entrada(Entrada proximo, T dados)
		{
			this.proximo = proximo;
			Dados = dados;
		}
	}
}