namespace RomanNumbersExam
{
    public class ConvertisseurNombresRomains
    {
       public static string Convertir(uint chiffreArabe)
        {
            if (chiffreArabe == 1) {
                return "I";
            } 
            else if (chiffreArabe == 2)
            {
                return "II";
            }
            return "III";
        }
    }
}