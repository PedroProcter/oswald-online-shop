class validation
{
    public static bool validateFields(List<string> data)
    {
        bool result = false;
        foreach (string item in data)
        {
            if (item == "" || item == null || item == "0")
            {
                result = true;
            }
        }
        return result;
    }

    public static string password(string password){
        string result = "";
        if (password.Length < 8)
        {
            result = "La contraseña debe tener al menos 8 caracteres";
        }
        else if (password.Length > 20)
        {
            result = "La contraseña debe tener menos de 20 caracteres";
        }
        else if (!password.Any(char.IsUpper))
        {
            result = "La contraseña debe tener al menos una mayuscula";
        }
        else if (!password.Any(char.IsLower))
        {
            result = "La contraseña debe tener al menos una minuscula";
        }
        else if (!password.Any(char.IsDigit))
        {
            result = "La contraseña debe tener al menos un numero";
        }
        else if (!password.Any(char.IsPunctuation))
        {
            result = "La contraseña debe tener al menos un caracter especial";
        }
        return result;
    }

}