using BTGPactual.IT.PME.Test;

[TestFixture]
public class ParedeTest
{
    [Test]
    public void TestEncontrarMenorNumeroDeTijolosCortados()
    {
        // Arrange
        var linhaDeTijolo1 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(1), new Tijolo(2), new Tijolo(2), new Tijolo(1) });
        var linhaDeTijolo2 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(3), new Tijolo(1), new Tijolo(2) });
        var linhaDeTijolo3 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(1), new Tijolo(3), new Tijolo(2) });
        var linhaDeTijolo4 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(2), new Tijolo(4) });
        var linhaDeTijolo5 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(3), new Tijolo(1), new Tijolo(2) });
        var linhaDeTijolo6 = new LinhaDeTijolos(new Tijolo[] { new Tijolo(1), new Tijolo(3), new Tijolo(1), new Tijolo(1) });

        // Act
        var parede = new Parede(new LinhaDeTijolos[] { linhaDeTijolo1, linhaDeTijolo2, linhaDeTijolo3, linhaDeTijolo4, linhaDeTijolo5, linhaDeTijolo6 });

        // Assert
        Assert.That(parede.EncontrarMenorNumeroDeTijolosCortados(), Is.EqualTo(2));
    }
}
