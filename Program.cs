static void Download(string fromAddress, string toAddress)
{

    using (var fromStream = new FileStream(fromAddress, FileMode.Open, FileAccess.Read))
    {
        using (var toStream = new FileStream(toAddress, FileMode.Create, FileAccess.Read)
)
        {
            var length = 10;
            var bytes = new byte[length];
            var size = fromAddress.Length;
            do
            {
                length = fromStream.Read(bytes, 0, length);
                toStream.Write(bytes, 0, length);
                Console.WriteLine($"{length} bytes read");
                size -= length;
            } while (size > 0);
        }
    }

}

//var from = Console.ReadLine();
//var to = Console.ReadLine();
string from = @"C:\Users\Gozel_ct64\Desktop\1\text.txt";
string to = @"C:\Users\Gozel_ct64\Desktop\2\2.txt";
var thread = new Thread(() => Download(from, to));
thread.Start();
thread.Join();
Console.WriteLine("Successfully finished");