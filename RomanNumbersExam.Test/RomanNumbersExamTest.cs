namespace RomanNumbersExam.Test
{
    public class RomanNumberExamTest
    {
        [Fact(DisplayName = "Etant donné le chiffre 1 " +
                            "Quand je le convertis en nombre romains" + 
                            "Alors j'obtiens I")]
        public void TestNombre1()
        {
            const uint chiffreArabe = 1;

            var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

            Assert.Equal("I", nombreRomain);
        }

        [Fact(DisplayName = "Etant donné le chiffre 2 " +
                            "Quand je le convertis en nombre romains" +
                            "Alors j'obtiens II")]
        public void TestNombre2()
        {
            const uint chiffreArabe = 2;

            var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

            Assert.Equal("II", nombreRomain);
        }
    }
}