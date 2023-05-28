public class StringSet
{
    private HashSet<string> set;

    public StringSet()
    {
        set = new HashSet<string>();
    }

    public void Add(string item)
    {
        set.Add(item);
    }

    public static StringSet operator +(StringSet set1, StringSet set2)
    {
        StringSet resultSet = new StringSet();
        foreach (string item in set1.set)
        {
            resultSet.Add(item);
        }

        foreach (string item in set2.set)
        {
            resultSet.Add(item);
        }

        return resultSet;
    }

    public static StringSet operator &(StringSet set1, StringSet set2)
    {
        StringSet resultSet = new StringSet();
        foreach (string item in set1.set)
        {
            if (set2.set.Contains(item))
            {
                resultSet.Add(item);
            }
        }

        return resultSet;
    }

    public void Print()
    {
        foreach (string item in set)
        {
            Console.WriteLine(item);
        }
    }
}

public class Matrix
{
    private int[,] matrix;
    private int rows;
    private int columns;

    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        matrix = new int[rows, columns];
    }

    public int this[int row, int column]
    {
        get { return matrix[row, column]; }
        set { matrix[row, column] = value; }
    }

    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

public class StringCollection
{
    private List<string> collection;

    public StringCollection()
    {
        collection = new List<string>();
    }

    public string this[int index]
    {
        get { return collection[index]; }
        set { collection[index] = value; }
    }

    public void Add(string item)
    {
        collection.Add(item);
    }

    public void Print()
    {
        foreach (string item in collection)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Пример использования класса StringSet
        StringSet set1 = new StringSet();
        set1.Add("apple");
        set1.Add("banana");

        StringSet set2 = new StringSet();
        set2.Add("banana");
        set2.Add("cherry");

        StringSet unionSet = set1 + set2;
        Console.WriteLine("Set:");
        unionSet.Print();

        StringSet intersectSet = set1 & set2;
        Console.WriteLine("Intersection set:");
        intersectSet.Print();

        // Пример использования класса Matrix
        Matrix matrix = new Matrix(3, 3);
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[1, 2] = 3;
        matrix[2, 2] = 4;

        Console.WriteLine("Matrix:");
        matrix.Print();

        // Пример использования класса StringCollection
        StringCollection collection = new StringCollection();
        collection.Add("string1");
        collection.Add("string2");
        collection.Add("string3");

        Console.WriteLine("String collection:");
        collection.Print();
    }
}
