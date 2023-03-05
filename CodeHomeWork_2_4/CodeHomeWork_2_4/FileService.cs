namespace CodeHomeWork_2_4
{
    public class FileService
    {
        public string _path = null;

        public string _fileName = null;

        public FileService()
        {
            _path = ".\\log\\";
            _fileName =$"{DateTime.Now.ToString("hh.hh.ss dd.MM.yyyy") + ".txt"}";
        }

        public string Path
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

        public string FileName
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
            using StreamWriter writer = new StreamWriter(_path + _fileName);
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
