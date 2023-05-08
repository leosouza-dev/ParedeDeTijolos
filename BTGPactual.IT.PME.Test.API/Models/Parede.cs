using BTGPactual.IT.PME.Test;

public class Parede
{
    private LinhaDeTijolos[] _linhasDeTijolos;
    public Parede(LinhaDeTijolos[] linhasDeTijolos)
    {
        _linhasDeTijolos = linhasDeTijolos;
    }

    public int EncontrarMenorNumeroDeTijolosCortados()
    {
        var quantidadeDeTijolos = new List<int>();
        var quantidadeMaxima = 0;
        for (int i = 0; i < _linhasDeTijolos.Length; i++)
        {
            var posicao = 0;
            for (int j = 0; j < _linhasDeTijolos[i].Tijolos.Length - 1; j++)
            {
                posicao += _linhasDeTijolos[i].Tijolos[j].Comprimento;
                if (quantidadeDeTijolos.Count <= posicao) 
                {
                    quantidadeDeTijolos.AddRange(new int[posicao + 1 - quantidadeDeTijolos.Count]); 
                }
                quantidadeDeTijolos[posicao]++;
                quantidadeMaxima = Math.Max(quantidadeMaxima, quantidadeDeTijolos[posicao]);
            }
        }
        return _linhasDeTijolos.Length - quantidadeMaxima;
    }
}
