namespace RomanNumbersExam.Test
{
    public class RomanNumberExamTest
    {

        [Theory(DisplayName = "Etant donn� le chiffre <nombreUnit�s>" + 
                               "Quand je le convertis en nombres romains" +
                                "Alors j'obtiens <nombreUnit�s> fois I")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void TestUnit�(uint nombreUnit�s)
        {
            var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnit�s);

            var r�sultatAttendu = new string(Enumerable.Repeat('I', (int)nombreUnit�s).ToArray());
            
            Assert.Equal(r�sultatAttendu, nombreRomain);
        }
    }
}