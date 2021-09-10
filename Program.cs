using System;

static class ArrayHelper {
    public static int Pop(ref int[] Array) {
        if (Array.Length == 1) {
            int temp = Array[0];
            Array = new int[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new int[Array.Length - 1];
        for (int i = 0; i < Array.Length - 1; ++i)
            createdArray[i] = Array[i];
        Array = createdArray;
        return Array[Array.Length - 1];
    }
    public static int Push(ref int[] Array, int el) {
        var createdArray = new int[Array.Length + 1]; for (int i = 0; i < Array.Length; ++i) createdArray[i] = Array[i];
        createdArray[Array.Length] = el;
        Array = createdArray;
        return createdArray.Length;
    }
    public static int Shift(ref int[] Array) {
        if (Array.Length == 1) {
            int temp = Array[0];
            Array = new int[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new int[Array.Length - 1];
        for (int i = 1; i < Array.Length; ++i)
            createdArray[i - 1] = Array[i];
        Array = createdArray;
        return Array[0];
    }
    public static int UnShift(ref int[] Array, int el) {
        var createdArray = new int[Array.Length + 1];
        createdArray[0] = el;
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i + 1] = Array[i];
        Array = createdArray;
        return createdArray.Length;
    }
    public static string Pop(ref string[] Array) {
        if (Array.Length == 1) {
            string temp = Array[0];
            Array = new string[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new string[Array.Length - 1];
        for (int i = 0; i < Array.Length - 1; ++i)
            createdArray[i] = Array[i];
        Array = createdArray;
        return Array[Array.Length - 1];
    }
    public static int Push(ref string[] Array, string el) {
        var createdArray = new string[Array.Length + 1];
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i] = Array[i];
        createdArray[Array.Length] = el;
        Array = createdArray;
        return createdArray.Length;
    }
    public static string Shift(ref string[] Array) {
        if (Array.Length == 1) {
            string temp = Array[0];
            Array = new string[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new string[Array.Length - 1];
        for (int i = 1; i < Array.Length; ++i)
            createdArray[i - 1] = Array[i];
        Array = createdArray;
        return Array[0];
    }
    public static int UnShift(ref string[] Array, string el) {
        var createdArray = new string[Array.Length + 1];
        createdArray[0] = el;
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i + 1] = Array[i];
        Array = createdArray;
        return createdArray.Length;
    }
    public static double Pop(ref double[] Array) {
        if (Array.Length == 1) {
            double temp = Array[0];
            Array = new double[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new double[Array.Length - 1];
        for (int i = 0; i < Array.Length - 1; ++i)
            createdArray[i] = Array[i];
        Array = createdArray;
        return Array[Array.Length - 1];
    }
    public static double Push(ref double[] Array, double el) {
        var createdArray = new double[Array.Length + 1];
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i] = Array[i];
        createdArray[Array.Length] = el;
        Array = createdArray;
        return createdArray.Length;
    }
    public static double Shift(ref double[] Array) {
        if (Array.Length == 1) {
            double temp = Array[0];
            Array = new double[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new double[Array.Length - 1];
        for (int i = 1; i < Array.Length; ++i)
            createdArray[i - 1] = Array[i];
        Array = createdArray;
        return Array[0];
    }
    public static double UnShift(ref double[] Array, double el) {
        var createdArray = new double[Array.Length + 1];
        createdArray[0] = el;
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i + 1] = Array[i];
        Array = createdArray;
        return createdArray.Length;
    }
    public static float Pop(ref float[] Array) {
        if (Array.Length == 1) {
            float temp = Array[0];
            Array = new float[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new float[Array.Length - 1];
        for (int i = 0; i < Array.Length - 1; ++i)
            createdArray[i] = Array[i];
        Array = createdArray;
        return Array[Array.Length - 1];
    }
    public static float Push(ref float[] Array, float el) {
        var createdArray = new float[Array.Length + 1];
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i] = Array[i];
        createdArray[Array.Length] = el;
        Array = createdArray;
        return createdArray.Length;
    }
    public static float Shift(ref float[] Array) {
        if (Array.Length == 1) {
            float temp = Array[0];
            Array = new float[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new float[Array.Length - 1];
        for (int i = 1; i < Array.Length; ++i)
            createdArray[i - 1] = Array[i];
        Array = createdArray;
        return Array[0];
    }
    public static float UnShift(ref float[] Array, float el) {
        var createdArray = new float[Array.Length + 1];
        createdArray[0] = el;
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i + 1] = Array[i];
        Array = createdArray;
        return createdArray.Length;
    }

    public static decimal Pop(ref decimal[] Array) {
        if (Array.Length == 1) {
            decimal temp = Array[0];
            Array = new decimal[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new decimal[Array.Length - 1];
        for (int i = 0; i < Array.Length - 1; ++i)
            createdArray[i] = Array[i];
        Array = createdArray;
        return Array[Array.Length - 1];
    }
    public static decimal Push(ref decimal[] Array, decimal el) {
        var createdArray = new decimal[Array.Length + 1];
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i] = Array[i];
        createdArray[Array.Length] = el;
        Array = createdArray;
        return createdArray.Length;
    }
    public static decimal Shift(ref decimal[] Array) {
        if (Array.Length == 1) {
            decimal temp = Array[0];
            Array = new decimal[] {};
            return temp;
        } else if (Array.Length < 1) throw new Exception("Array already empty !");
        var createdArray = new decimal[Array.Length - 1];
        for (int i = 1; i < Array.Length; ++i)
            createdArray[i - 1] = Array[i];
        Array = createdArray;
        return Array[0];
    }
    public static decimal UnShift(ref decimal[] Array, decimal el) {
        var createdArray = new decimal[Array.Length + 1];
        createdArray[0] = el;
        for (int i = 0; i < Array.Length; ++i)
            createdArray[i + 1] = Array[i];
        Array = createdArray;
        return createdArray.Length;
    }
}
class Program {
    static void Main() {
        var a = new int [5] {1, 2, 3, 4, 5};
        Console.WriteLine("\nArray: ");
        for (int i = 0; i < 5; ++i) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine("\nPOP");
        ArrayHelper.Pop(ref a);
        Console.WriteLine("\nArray: ");
        for (int i = 0; i < 5 - 1; ++i) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine("\nPush 5");
        ArrayHelper.Push(ref a, 5);
        Console.WriteLine("\nArray: ");
        for (int i = 0; i < 5; ++i) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine("\nShift");
        ArrayHelper.Shift(ref a);
        Console.WriteLine("\nArray: ");
        for (int i = 0; i < 5 - 1; ++i) {
            Console.Write($"{a[i]} ");
        }

        Console.WriteLine("\nUnshift 12");
        ArrayHelper.UnShift(ref a, 12);
        Console.WriteLine("\nArray: ");
        for (int i = 0; i < 5; ++i) {
            Console.Write($"{a[i]} ");
        }
    }
}
