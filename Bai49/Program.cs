using System;
using System.Text;

class Program
{
    // Hàm generic để tìm giá trị nhỏ nhất trong mảng
    public static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng");
        }

        T minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(minValue) < 0)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khai báo 1 biến kiểu dynamic là min_value
        dynamic min_value;

        // Mảng số nguyên 4 byte
        int[] intArray = { 3, 5, 2, 8, 1 };
        min_value = FindMinValue(intArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên 4 byte: " + min_value.ToString());

        // Mảng số nguyên không dấu 4 byte
        uint[] uintArray = { 3u, 5u, 2u, 8u, 1u };
        min_value = FindMinValue(uintArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên không dấu 4 byte: " + min_value.ToString());

        // Mảng số thực 4 byte
        float[] floatArray = { 3.5f, 5.2f, 2.1f, 8.3f, 1.6f };
        min_value = FindMinValue(floatArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 4 byte: " + min_value.ToString());

        // Mảng số thực 8 byte
        double[] doubleArray = { 3.5, 5.2, 2.1, 8.3, 1.6 };
        min_value = FindMinValue(doubleArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 8 byte: " + min_value.ToString());
    }
}
