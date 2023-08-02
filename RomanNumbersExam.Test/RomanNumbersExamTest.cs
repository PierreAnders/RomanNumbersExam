namespace RomanNumbersExam.Test
{
    public class RomanNumberExamTest
    {
        [Fact(DisplayName = "Etant donn� le chiffre 1 " +
                            "Quand je le convertis en nombre romains" + 
                            "Alors j'obtiens I")]
        public void TestNombre1()
        {
            const uint chiffreArabe = 1;

            var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

            Assert.Equal("I", nombreRomain);
        }
    }
}