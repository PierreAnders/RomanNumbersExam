namespace RomanNumbersExam
{
    public class ConvertisseurNombresRomains
    {
        public static string Convertir(uint chiffreArabe)
        {
            switch (chiffreArabe)
            {
                case <= 3:
                    return new string('I', (int)chiffreArabe);

                default:
                    return "IV";
            }
        }
    }
}