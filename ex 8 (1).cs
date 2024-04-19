/* Создать класс EngMoney для работы с устаревшей денежной системой Великобритании. В ней использовались фунты, шиллинги и пенсы.
 * При этом: 1 фунт = 20 шиллингов, 1 шиллинг = 12 пенсов. Денежные суммы будут задаваться в фунтах, шиллингах и пенсах и результат
 * выдаваться также в этих величинах. Должны быть реализованы: сложение и вычитание, умножение и деление, сравнение сумм. */

uint GoodInput(string s)
{
    uint n;
    try
    {
        n = Convert.ToUInt32(s);
    }
    catch (FormatException)
    {
        Console.WriteLine("Денежные суммы - положительные целые числа");
        return GoodInput(Console.ReadLine());
    }
    catch (OverflowException)
    {
        Console.WriteLine("Введенное число слишком большое");
        return GoodInput(Console.ReadLine());
    }
    return n;
}
float GoodInputk(string s)
{
    float k;
    try
    {
        k = Convert.ToSingle(s);
        if (k < 0)
        {
            throw new FormatException();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Введенная строка должна являться положительным числом");
        return GoodInput(Console.ReadLine());
    }
    catch (OverflowException)
    {
        Console.WriteLine("Введенное число слишком большое");
        return GoodInput(Console.ReadLine());
    }
    return k;
}

Console.WriteLine("Формат вводимых данных: фунты, шиллинги, пенсы");
Console.WriteLine("Введите первую сумму: ");
EngMoney money1 = new EngMoney(GoodInput(Console.ReadLine()), GoodInput(Console.ReadLine()), GoodInput(Console.ReadLine()));
Console.WriteLine("Введите вторую сумму: ");
EngMoney money2 = new EngMoney(GoodInput(Console.ReadLine()), GoodInput(Console.ReadLine()), GoodInput(Console.ReadLine()));
Console.WriteLine($"Сумма 1: {money1}\nСумма 2: {money2}\n");
Console.Write("Сравнение: ");
sbyte comp = money1.Compare(money2);
if (comp == 1)
{
    Console.WriteLine("Первая сумма больше второй");
    Console.Write("Разность: ");
    Console.WriteLine(money1 - money2);
}
else if (comp == 0)
{
    Console.WriteLine("Суммы равны");
    Console.Write("Разность: ");
    Console.WriteLine(money1 - money2);
}
else
{
    Console.WriteLine("Первая сумма меньше второй");
}
Console.WriteLine("Сумма: ");
Console.WriteLine(money1 + money2);
Console.Write("Введите число: ");
float k = GoodInputk(Console.ReadLine());
Console.WriteLine("Произведение: ");
Console.WriteLine(money1.Mult(k));
Console.WriteLine(money2.Mult(k));
Console.WriteLine("Частное: ");
Console.WriteLine(money1.Div(k));
Console.WriteLine(money2.Div(k));

class EngMoney
{
    internal ulong pound;
    internal ulong shilling;
    internal ulong pence;
    internal EngMoney(uint pound, uint shilling, uint pence)
    {
        this.pound = pound;
        this.shilling = shilling;
        this.pence = pence;
        this.GoodLooking();
    }
    internal EngMoney()
    {
        this.pound = 0;
        this.shilling = 0;
        this.pence = 0;
    }
    internal ulong AsPence
    {
        get { return ((this.pound * 20) + this.shilling) * 12 + this.pence; }
    }
    internal EngMoney GoodLooking()
    {
        this.shilling += this.pence / 12;
        this.pence %= 12;
        this.pound += this.shilling / 20;
        this.shilling %= 20;
        return this;
    }
    public sbyte Compare(EngMoney money2)
    {
        if (this.AsPence > money2.AsPence)
        {
            return 1;
        }
        else if (this.AsPence == money2.AsPence)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
    public override string ToString()
    {
        this.GoodLooking();
        return $"{this.pound} ф. {this.shilling} ш. {this.pence} п.";
    }
    public static EngMoney operator +(EngMoney left, EngMoney right)
    {
        EngMoney money = new EngMoney();
        money.pence += left.pence + right.pence;
        money.shilling += left.shilling + right.shilling;
        money.pound += left.pound + right.pound;
        money.GoodLooking();
        return money;
    }
    public static EngMoney operator -(EngMoney left, EngMoney right)
    {
        EngMoney money = new EngMoney();
        money.pence += left.pence - right.pence;
        money.shilling += left.shilling - right.shilling;
        money.pound += left.pound - right.pound;
        money.GoodLooking();
        return money;
    }
    internal EngMoney Mult(float k)
    {
        EngMoney money = new EngMoney();
        double pen = this.AsPence;
        pen *= k;
        money.pence = Convert.ToUInt32(Math.Round(pen, MidpointRounding.ToZero));
        money.GoodLooking();
        return money;
    }
    internal EngMoney Div(double k)
    {
        EngMoney money = new EngMoney();
        double pen = this.AsPence;
        pen /= k;
        money.pence = Convert.ToUInt32(Math.Round(pen, MidpointRounding.ToZero));
        money.GoodLooking();
        return money;
    }
}
