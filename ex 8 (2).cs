/* Создать класс Fraction для работы с дробными числами. Число должно быть представлено двумя полями:
 * целая часть – длинное целое со знаком, дробная часть – беззнаковое короткое целое.
 * Реализовать арифметические операции сложения, вычитания, умножения и операции сравнения. */

// много знаков слева [-2 147 483 648, 2 147 483 647]
string InputInteger(string s)
{
    int n;
    try
    {
        n = Convert.ToInt32(s);
    }
    catch (FormatException)
    {
        Console.WriteLine("Целая часть должна быть целым числом");
        return InputInteger(Console.ReadLine());
    }
    catch (OverflowException)
    {
        Console.WriteLine("Целая часть слишком большое число");
        return InputInteger(Console.ReadLine());
    }
    if (s[0] != '-')
    {
        s = string.Concat('+', s);
    }
    return s;
}
// 4 знака справа [0, 9999]
short InputFraction(string s)
{
    short n;
    while (s.Length < 4)
    {
        s = string.Concat(s, "0");
    }
    try
    {
        n = Convert.ToInt16(s);
        if (n / 10000 >= 1 || s.Length > 4)
        {
            throw new OverflowException();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Дробная часть должна быть целым, положительным числом");
        return InputFraction(Console.ReadLine());
    }
    catch (OverflowException)
    {
        Console.WriteLine("Дробная часть должна быть 4-значным числом");
        return InputFraction(Console.ReadLine());
    }
    return n;
}

Fraction New(string s)
{
    int splitIndex = s.IndexOf(',');
    Fraction result;
    if (splitIndex == -1)
    {
        result = new Fraction(InputInteger(s), 0);
    }
    else
    {
        result = new Fraction(InputInteger(s[..splitIndex]), InputFraction(s[(splitIndex + 1)..]));
    }
    return result;
}

Console.Write("Введите первое число: ");
Fraction first = New(Console.ReadLine());
Console.Write("Введите второе число: ");
Fraction second = New(Console.ReadLine());


Console.WriteLine($"Сложение: {first + second}");
Console.WriteLine($"Вычитание: {first - second}");
Console.WriteLine($"Умножение: {first * second}");
Console.WriteLine($"first < second: {first < second}");
Console.WriteLine($"first > second: {first > second}");
Console.WriteLine($"first <= second: {first <= second}");
Console.WriteLine($"first >= second: {first >= second}");
Console.WriteLine($"first == second: {first == second}");
Console.WriteLine($"first != second: {first != second}");

class Fraction
{
    // internal int S_integer;
    internal int integer;
    internal short fraction;
    internal char sign;

    public override string ToString()
    {
        string S_fraction = Convert.ToString(this.fraction);
        while (S_fraction.Length < 4)
        {
            S_fraction = string.Concat("0", S_fraction);
        }
        if (this.sign == '+')
        {
            return $"{integer},{S_fraction}";
        }
        return $"{sign}{integer},{S_fraction}";
    }
    public static Fraction ToFraction(long n)
    {
        Fraction one = new Fraction();
        one.integer = Convert.ToInt32(n / 10000);
        one.fraction = Convert.ToInt16(n % 10000);
        return one;
    }
    internal Fraction(string S_integer, short fraction)
    {
        this.sign = S_integer[0];
        this.integer = Convert.ToInt32(S_integer[1..]);
        this.fraction = fraction;
    }
    internal Fraction()
    {
        this.sign = '+';
        this.integer = 0;
        this.fraction = 0;
    }
    public static Fraction operator +(Fraction left, Fraction right)
    {
        Fraction result = new Fraction();
        if (left.sign == '+' & right.sign == '+') // то, к чему нужно привести все
        {
            result.integer = left.integer + right.integer;
            result.integer += (left.fraction + right.fraction) / 10000;
            result.fraction += Convert.ToInt16(Convert.ToInt16(left.fraction + right.fraction) % 10000);
        }
        else if (left.sign == '-' & right.sign == '+')
        {
            result = right - -left;
        }
        else if (left.sign == '+' & right.sign == '-')
        {
            result = left - -right;
        }
        else
        {
            result = -(-left + -right);
        }
        return result;
    }
    public static Fraction operator -(Fraction left, Fraction right)
    {
        Fraction result = new Fraction();
        if (left.sign == '+' & right.sign == '+') // нормальный случай, к которому все сводится
        {
            if (left > right)
            {
                result.integer = left.integer - right.integer;
                if (left.fraction > right.fraction || left.fraction == right.fraction)
                {
                    result.fraction = Convert.ToInt16(left.fraction - right.fraction);
                }
                else
                {
                    result.integer--;
                    result.fraction = Convert.ToInt16(10000 - (right.fraction - left.fraction));
                }
            }
            else
            {
                result.sign = '-';
                result.integer = right.integer - left.integer;
                if (left.fraction < right.fraction || left.fraction == right.fraction)
                {
                    result.fraction = Convert.ToInt16(right.fraction - left.fraction);
                }
                else
                {
                    result.integer--;
                    result.fraction = Convert.ToInt16(10000 - (left.fraction - right.fraction));
                }
            }
        }
        else if (left.sign == '-' & right.sign == '+') // -(left + right)
        {
            result = -(-left + right);
        }
        else if (left.sign == '+' & right.sign == '-') // left + right
        {
            result = left + -right;
        }
        else // right - left
        {
            result = -(-right + -left);
        }
        return result;
    }
    public static Fraction operator -(Fraction left)
    {
        Fraction result = new Fraction();
        if (left.sign != '-')
        {
            result.sign = '-';
        }
        result.integer = left.integer;
        result.fraction = left.fraction;
        return result;
    }
    public static Fraction operator *(Fraction left, Fraction right)
    {
        string S_fraction = Convert.ToString(left.fraction);
        while (S_fraction.Length < 4)
        {
            S_fraction = string.Concat("0", S_fraction);
        }
        long a = Convert.ToInt64(string.Concat(Convert.ToString(left.integer), S_fraction));
        S_fraction = Convert.ToString(right.fraction);
        while (S_fraction.Length < 4)
        {
            S_fraction = string.Concat("0", S_fraction);
        }
        long b = Convert.ToInt64(string.Concat(Convert.ToString(right.integer), S_fraction));
        Fraction result = ToFraction(a * b / 10000);
        if (left.sign != right.sign)
        {
            result.sign = '-';
        }
        return result;
    }
    public static bool operator >(Fraction left, Fraction right)
    {
        if (left.sign == '+' & right.sign == '+')
        {
            if (left.integer > right.integer)
            {
                return true;
            }
            else if (left.integer == right.integer)
            {
                if (left.fraction > right.fraction)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else if (left.sign == '+' & right.sign == '-')
        {
            return true;
        }
        else if (left.sign == '-' & right.sign == '+')
        {
            return false;
        }
        else
        {
            return -right > -left;
        }
    }
    public static bool operator >=(Fraction left, Fraction right)
    {
        if (left.sign == '+' & right.sign == '+')
        {
            if (left.integer > right.integer)
            {
                return true;
            }
            else if (left.integer == right.integer)
            {
                if (left.fraction >= right.fraction)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else if (left.sign == '+' & right.sign == '-')
        {
            return true;
        }
        else if (left.sign == '-' & right.sign == '+')
        {
            return false;
        }
        else
        {
            return -right >= -left;
        }
    }
    public static bool operator <=(Fraction left, Fraction right)
    {
        return !(left > right);
    }
    public static bool operator <(Fraction left, Fraction right)
    {
        return !(left >= right);
    }
    public static bool operator ==(Fraction left, Fraction right)
    {
        if (left.sign == right.sign)
        {
            if (left.integer == right.integer)
            {
                return (left.fraction == right.fraction) ? true : false;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    public static bool operator !=(Fraction left, Fraction right)
    {
        if (left == right)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}