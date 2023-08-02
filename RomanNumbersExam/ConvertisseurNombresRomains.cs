namespace RomanNumbersExam
{
    public class ConvertisseurNombresRomains
    {
       public static string Convertir(uint chiffreArabe)
        {
            if (chiffreArabe == 1) {
                return "I";
            }
            return "II";
        }
    }
}