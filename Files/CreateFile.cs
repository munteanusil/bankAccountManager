namespace Conventions.Files
{
    public class CreateFile
    {
        public static void CreateTextFile(string name, string[] content)
        {
            string path = $"C:\\Users\\NURSU\\Desktop\\Conventions\\{name}.txt";
            File.CreateText(path).Close();
            File.WriteAllLines(path, content);
            //using StreamWriter writer = new StreamWriter(path);
            //{
            //    foreach (var c in content)
            //    {
            //        writer.WriteLine(c);
            //    }
            //}

            using StreamReader reader = new StreamReader(path);
            {
                var continut = reader.ReadToEnd();
                Console.WriteLine(continut);
            }
        }

        public static void CreateTextFileWithReadonly(string name)
        {
            string path = $"C:\\Users\\NURSU\\Desktop\\Conventions\\{name}.txt";
            //File.CreateText(path).Close();
            var file = new FileInfo(path);
            file.Attributes |= FileAttributes.ReadOnly;
            Console.WriteLine("Attribute dupa setare ReadOnly" + file.Attributes);
            if ((file.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("Fisierul este readonly");
            }
            file.Attributes |= FileAttributes.Hidden;
            //file.Attributes &= ~FileAttributes.ReadOnly;
            //if ((file.Attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            //{
            //    Console.WriteLine("Fisierul nu este readonly");
            //}
        }

        public static void CrateTextFileWithModifiedTime(string name)
        {
            string path = $"C:\\Users\\NURSU\\Desktop\\Conventions\\{name}.txt";
            File.CreateText(path).Close();
            var file = new FileInfo(path);
            file.LastAccessTime = new DateTime(2030, 1, 1);
            file.LastWriteTime = new DateTime(2032, 1, 1);
        }

        public static void CreateDirectory(string folderName)
        {
            string path = $"C:\\Users\\NURSU\\Desktop\\Conventions\\{folderName}";
            Directory.CreateDirectory(path);
            string filePath = path + "\\test.txt";
            File.CreateText(filePath).Close();
            File.WriteAllLines(filePath, new string[] { "slkdjflkjsdlkfj", "sdkjflksjdkfj" });
            Console.WriteLine(string.Join(' ', Directory.GetFiles(path)));
        }
    }
}
