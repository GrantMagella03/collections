using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        string nums = "3388888888822222222222267676731469031744382002290183463621804303819191919191919191919191919195555555555557777777777664668342013403160413028644697845396846597965341327368475875964534247384950756432981408236502846000000000";
        Dictionary<string, int> DictN = new(); //{{"1",0},{"2",0},{"3",0},{"4",0},{"5",0},{"6",0},{"7",0},{"8",0},{"9",0},{"0",0}};
        foreach(var ch in nums.ToCharArray()) {
            if (!DictN.ContainsKey(ch.ToString())) {
                DictN[ch.ToString()] = 0;
            }
            DictN[ch.ToString()]++;
        }
        foreach(string key in DictN.Keys) {
            Console.WriteLine($"{key}:{DictN[key]}");
        }
        /*
        List<int> alist = new() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
        Console.WriteLine(alist.Capacity +" "+ alist[23]);
        Dictionary<string, string> Dict = new() {{ "1", "red" },{ "2", "White" },{ "3", "Blue" },{ "4", "Orange" }};
        Console.WriteLine($"Color #4={Dict["4"]}");
        //List<string> names = new() {"Tony", "Megan", "Grant", "Drew", "David", "Josh"}; // better way
        List<string> names = new();
        names.Add("Tony");
        names.Add("Megan");
        names.Add("Grant");
        names.Add("Drew");
        names.Add("David");
        names.Add("Josh");

        names.Remove("Josh");

        foreach (string name in names) {
            Console.WriteLine(name);
        }
         */
    }
}