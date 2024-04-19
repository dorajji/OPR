/* Описать классы «Шахматная фигура», «Легкая фигура», «Тяжелая фигура», «Пешка», «Король», «Слон», «Ладья».
 * Выстроить правильную иерархию наследования этих классов, определить какие из классов должны быть абстрактными,
 * какие методы абстрактными или виртуальными. Описать конструкторы и деструкторы разработанных классов.
 * Создать по одному объекту каждого класса, для которого это возможно, поместить их в один массив.
 * Считать, что все элементы массива — это фигуры на доске. Для объекта класса «Король» метод Сastling (возможность рокировки)
 * и вывести на экран все свойства каждого из объектов. */

byte[] GoodInput(ChessPieces[] board, string x_, string y_, byte choice)
{
    byte limity = 0;
    byte x, y;
    byte[] coords = [0, 0];
    try
    {
        x = Convert.ToByte(Convert.ToByte(x_) - 1);
        y = Convert.ToByte(Convert.ToByte(y_) - 1);
        if (choice == 1) // для пешек, потому что они не могут стоять на клетках с координатами (x, 1)
        {
            limity = 1;
        }
        if (x < 0 || x > 7 || y < limity || y > 7) // проверка, находится ли это поле на доске
        {
            throw new Exception();
        }
        if (ChessPieces.IsTherePiece(board, x, y)) // нет ли на этом поле фигуры
        {
            throw new NewExeption();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Координаты являются натуральными числами меньше 9");
        return GoodInput(board, Console.ReadLine(), Console.ReadLine(), choice);
    }
    catch (NewExeption)
    {
        Console.WriteLine("На этом месте уже находится фигура, введите координаты снова");
        return GoodInput(board, Console.ReadLine(), Console.ReadLine(), choice);
    }
    catch (Exception)
    {
        Console.WriteLine("Эта фигура не может здесь стоять, так как она выходит за пределы доски");
        return GoodInput(board, Console.ReadLine(), Console.ReadLine(), choice);
    }
    return [x, y];
}

ChessPieces[] board = [new Pawn(), new Pawn(), new Pawn(), new Pawn()];
byte[] coords;

Console.WriteLine("Все фигуры белые");
Console.WriteLine("Введите координаты фигур (x, y): \n");

Console.WriteLine("Пешка");
coords = GoodInput(board, Console.ReadLine(), Console.ReadLine(), 1);
board[0] = new Pawn(coords[0], coords[1]);

Console.WriteLine("\nСлон");
coords = GoodInput(board, Console.ReadLine(), Console.ReadLine(), 0);
board[1] = new Bishop(coords[0], coords[1]);

Console.WriteLine("\nКороль");
coords = GoodInput(board, Console.ReadLine(), Console.ReadLine(), 0);
board[2] = new King(coords[0], coords[1]);

Console.WriteLine("\nЛадья");
coords = GoodInput(board, Console.ReadLine(), Console.ReadLine(), 0);
board[3] = new Rook(coords[0], coords[1]);
Console.WriteLine();

Console.WriteLine("Координаты всех фигур на доске и правила, по которым они могут передвигаться на доске: \n");
foreach (ChessPieces piece in board)
{
    Console.Write($"{piece} (");
    piece.Dispose();
    Console.WriteLine($"): {piece.Position}");
    Console.WriteLine($"{piece.Move()}\n{piece.Capture()}\n");
}

if (board[2].Castling(board))
{
    Console.WriteLine("Рокировка возможна");
}
else
{
    Console.WriteLine("Рокировка не возможна");
}

public abstract class ChessPieces : IDisposable // шахматы
{
    public byte x, y;
    /// <returns>правило, по которому фигура может перемещаться на доске</returns>
    public abstract string Move();
    /// <returns>правило, по которому фигура может делать захват</returns>
    public abstract string Capture();
    /// <returns>true, если на этой клетке уже есть фигура, false, если нет</returns>
    public static bool IsTherePiece(ChessPieces[] board, byte x_, byte y_)
    {
        foreach (var piece in board)
        {
            if (piece.x == x_ & piece.y == y_)
            {
                return true;
            }
        }
        return false;
    }
    /// <returns>проверяет возможность рокировки</returns>
    public virtual bool Castling(ChessPieces[] board)
    {
        return false;
    }
    public abstract void Dispose(); // деструктор
    /// <summary>
    /// возвращает координаты фигуры
    /// </summary>
    public string Position
    {
        get
        {
            return $"({this.x + 1}, {this.y + 1})";
        }
    }
}
public abstract class MajorPieces : ChessPieces; // тяжелые фигуры - ферзь и ладья
public abstract class MinorPieces : ChessPieces; // легкие фигуры - конь и слон
public class Pawn : ChessPieces // пешки
{
    public Pawn()
    {
        this.x = 0;
        this.y = 0;
    }
    public Pawn(byte x_, byte y_)
    {
        this.x = x_;
        this.y = y_;
    }
    public override string Move()
    {
        return "Ходит на 1 или 2 клетки вперед";
    }
    public override string Capture()
    {
        return "Ходит со взятием по диагонали на одно поле вперед";
    }
    public override void Dispose()
    {
        Console.Write($"Pawn");
    }
    public override string ToString()
    {
        return "Пешка";
    }
}
public class King : ChessPieces // король
{
    public King()
    {
        this.x = 4;
        this.y = 0;
    }
    public King(byte x_, byte y_)
    {
        this.x = x_;
        this.y = y_;
    }
    public override string Move()
    {
        return "Ходит на соседнюю клетку по вертикали, горизонтали или диагонали";
    }
    public override string Capture()
    {
        return "Ходит со взятием на соседнюю клетку по вертикали, горизонтали или диагонали";
    }
    public override void Dispose()
    {
        Console.Write($"King");
    }
    public override bool Castling(ChessPieces[] board)
    {
        if (this.y == 0 & x == 4)
        {
            foreach (ChessPieces obj in board)
            {
                if (ReferenceEquals(obj.GetType(), new Rook().GetType()))
                {
                    if (obj.x == 0)
                    {
                        for (byte i = 1; i < 4; i++)
                        {
                            int k = 0;
                            if (IsTherePiece(board, i, 0))
                            {
                                k++;
                            }
                            if (k == 0)
                            {
                                return true;
                            }
                            return false;
                        }
                    }
                    else if (obj.x == 7)
                    {
                        for (byte i = 5; i < 7; i++)
                        {
                            int k = 0;
                            if (IsTherePiece(board, i, 0))
                            {
                                k++;
                            }
                            if (k == 0)
                            {
                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
        }
        return false;
    }
    public override string ToString()
    {
        return "Король";
    }
}
public class Bishop : MinorPieces // слон
{
    public Bishop()
    {
        this.y = 0;
        this.x = 5;
    }
    public Bishop(byte x_, byte y_)
    {
        this.y = y_;
        this.x = x_;
    }
    public override string Move()
    {
        return "Ходит по диагонали на любое расстояние";
    }
    public override string Capture()
    {
        return "Ходит со взятием по диагонали на любое расстояние";
    }
    public override void Dispose()
    {
        Console.Write($"Bishop");
    }
    public override string ToString()
    {
        return "Слон";
    }
}
public class Rook : MajorPieces // ладья
{
    public Rook()
    {
        this.x = 0;
        this.y = 0;
    }
    public Rook(byte x_, byte y_)
    {
        this.x = x_;
        this.y = y_;
    }
    public override string Move()
    {
        return "Ходит на любое расстояние по вертикали или горизонтали";
    }
    public override string Capture()
    {
        return "Ходит со взятием на любое расстояние по вертикали или горизонтали";
    }
    public override void Dispose()
    {
        Console.Write($"Rook");
    }
    public override string ToString()
    {
        return "Ладья";
    }
}

class NewExeption : Exception { }