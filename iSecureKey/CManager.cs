using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using MetroFramework;

namespace SecureKey
{
    public static class CManager
    {
        public const int KEY_LENGTH = 32;
        public const int IV_LENGTH = 32;
        private const int RAMDOM_LENGTH = 10;
        private const int USER_LENGTH = 32;

        //public static readonly byte[] KEY_APP = Encoding.UTF8.GetBytes("nUcncSJze0jg2wZfgd7pcRSfLyGrKwjn");

        private const string DIR_FILES = "files";
        private const string FILE_EXTENSION = ".fscr";

        public static readonly string  PATH_DIR_FIELS = Path.Combine( Environment.CurrentDirectory, DIR_FILES);

        public static List<CDataEncrypt> ListFiles = new List<CDataEncrypt>();

        public static string UserLogin = string.Empty;
        
        public static string PassWordLogin = string.Empty;

        public  static string FileSource = string.Empty;        

        public static void CreateFirstFile()
        {
            string NameFile = Path.GetRandomFileName() + FILE_EXTENSION;
            string PathFile = Path.Combine(PATH_DIR_FIELS, NameFile);

            FileSource = PathFile;            
        }

        public static void SaveDocument()
        {            
            WolfSll Encrypter = new WolfSll();

            byte[] StrRamdom = Encrypter.GererateRamdomKEY(RAMDOM_LENGTH);
            
            byte[] UserPlain = Encoding.UTF8.GetBytes(UserLogin.PadRight(USER_LENGTH));
            byte[] UserEncryp = Encrypter.EncryptByte(UserPlain ,
                                Encoding.UTF8.GetBytes(PassWordLogin.PadRight(USER_LENGTH)));

            byte[] XmlData = SerializeDataFile();

            int remainer = XmlData.Length % 32;
            int mult = XmlData.Length / 32;
            if (remainer > 0)
                mult += 1;

            Array.Resize(ref XmlData, mult*32);

            byte[] EncryptData = Encrypter.EncryptByte(XmlData, 
                                Encoding.UTF8.GetBytes(PassWordLogin.PadRight(USER_LENGTH)));

            FileMode FM = FileMode.OpenOrCreate;
            if (File.Exists(FileSource))
                FM = FileMode.Truncate;

            using (FileStream stream = new FileStream(FileSource, FM, FileAccess.Write))
            {
                stream.Write(StrRamdom, 0, StrRamdom.Length);
                stream.Write(Encrypter.IV, 0, Encrypter.IV.Length);
                stream.Write(UserEncryp, 0, UserEncryp.Length);                
                stream.Write(EncryptData, 0, EncryptData.Length);
                //stream.Close();
            }
        }

        public static Boolean LoadDocument(string mUser, string mPassword )
        {
            byte[] XmlByte = null;
            using (FileStream stream = new FileStream(FileSource, FileMode.Open, FileAccess.Read))
            {
                
                stream.Position = RAMDOM_LENGTH;
                byte[] keyIV = new byte[IV_LENGTH];
                int bytesRead = stream.Read(keyIV, 0, keyIV.Length);
                WolfSll Decrypter = new WolfSll();
                Decrypter.IV = keyIV;

                byte[] UserByte = new byte[USER_LENGTH];
                bytesRead = stream.Read(UserByte, 0, UserByte.Length);

                byte[] Out =  Decrypter.DecryptByte(UserByte, 
                                    Encoding.UTF8.GetBytes(mPassword.PadRight(USER_LENGTH)));

                string UserName = Encoding.UTF8.GetString(Out).Trim();

                if (UserName != mUser)
                    return false;

                byte[] DataByte = new byte[stream.Length - stream.Position];  
                bytesRead = stream.Read(DataByte, 0, DataByte.Length);

                XmlByte =  Decrypter.DecryptByte(DataByte, Encoding.UTF8.GetBytes(mPassword.PadRight(USER_LENGTH)));

                if (XmlByte == null)
                    return false;
            }

            DeserializeDataFile(XmlByte);

            CManager.UserLogin = mUser;
            CManager.PassWordLogin = mPassword;
            return true;
        }


        private static byte[] SerializeDataFile()
        {
            MemoryStream memSteam = new MemoryStream();
            using (StreamWriter writer = new StreamWriter(memSteam))
            {
                XmlSerializer x = new XmlSerializer(ListFiles.GetType());
                x.Serialize(writer, ListFiles);
                writer.Flush();                
                memSteam.Position = 0;
                return memSteam.ToArray();
            }
        }

        private static Boolean DeserializeDataFile( byte[] XmlData)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(ListFiles.GetType());
                using (Stream stream = new MemoryStream(XmlData))
                    ListFiles = (List<CDataEncrypt>)serializer.Deserialize(stream);
                return true;
            }
            catch { }
            return false;
        }        
    }
}
/*
 Estructura del document
1- 10 bytes random
2- 32 bytes IV
3- 32 Nom usuari (encriptat amb IV + password)
4- dades xml (encriptat amb IV + password)
 */