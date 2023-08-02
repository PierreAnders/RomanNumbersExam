namespace RomanNumbersExam.Test
{
    public class RomanNumberExamTest
    {

        [Theory(DisplayName = "Etant donné le chiffre <nombreUnités>" + 
                               "Quand je le convertis en nombres romains" +
                                "Alors j'obtiens <nombreUnités> fois I")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void TestUnité(uint nombreUnités)
        {
            var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

            var résultatAttendu = new string(Enumerable.Repeat('I', (int)nombreUnités).ToArray());
            
            Assert.Equal(résultatAttendu, nombreRomain);
        }

        [Fact(DisplayName = "Etant donné le chiffre 4 " +
                            "Quand je le convertis en nombre romains" +
                            "Alors j'obtiens IV")]
        public void TestNombre4()
        {
            const uint chiffreArabe = 4;

            var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

            Assert.Equal("IV", nombreRomain);
        }
    }
}