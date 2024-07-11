using System.Text;

namespace Bai48
{
    class Student
    {
        public string ID { get; set; }
        public float GPA { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, float> dict1 = new Dictionary<string, float>();
            while(true)
            {
                Console.Write("Nhập Id của sinh viên (nhập # để dừng): ");
                string id = Console.ReadLine();
                if(id == "#")
                {
                    break;
                }
                Console.Write("Nhập Gpa của sinh viên: ");
                string inputGpa = Console.ReadLine();
                if(float.TryParse(inputGpa, out float gpa)) {
                    dict1[id] = gpa;
                }
                else
                {
                    Console.WriteLine("Gpa không hợp lệ, bỏ qua sinh viên này");
                }

                string searchID = "123456";
                if(dict1.ContainsKey(searchID))
                {
                    Console.WriteLine($"Điểm của sinh viên có id {searchID} là: {dict1[searchID]}");
                }else
                {
                    Console.WriteLine($"Không tìm thấy sinh viên có id {searchID}");
                }
            }
        }
    }
}
