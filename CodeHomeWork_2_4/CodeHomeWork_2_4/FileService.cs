namespace CodeHomeWork_2_4
{
    public class FileService
    {
        private static string _path = string.Empty;

        private static string _fileName = string.Empty;

        static FileService()
        {
            _path = Path;
            _fileName = FileName;
        }

        public static string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public static string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }

        public void StreamWriter(string log)
        {
            DirectoryInfo();
            using StreamWriter writer = new(_path + _fileName);
            writer.Write(log);
        }

        public void DirectoryInfo()
        {
            if (Directory.Exists(_path))
            {
                DirectoryInfo info = new DirectoryInfo(_path);
                FileInfo[] fileInfo = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();

                if (fileInfo.Length > 3)
                {
                    fileInfo[0].Delete();
                }
            }
            else
            {
                Directory.CreateDirectory(_path);
            }
        }
    }
}
