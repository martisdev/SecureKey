using MSC.WolfSslNet;
namespace SecureKey
{
    public class WolfSll
    {
        #region PROPERTIES

        public byte[] IV
        {
            set;
            get;
        }

        #endregion

        #region CONSTRUCTOR

        public WolfSll()
        {
            GenerateIV();
        }

        #endregion

        #region METHODS ENCRYPT
        
        /// <summary>
        /// Encrypt a byte
        /// </summary>
        /// <param name="mInput">Byte to encrypt</param>        
        /// <returns>byte array encrypted</returns>
        public byte[] EncryptByte(byte[] mInput, byte[] keyForEncrypt)
        {            
            CAes Aes = new CAes();
            CWolfSsl.ReturnCode rc = Aes.AesCbcEncrypt(mInput, keyForEncrypt, IV, out byte[] ouput);
            if (rc != CWolfSsl.ReturnCode.Ok)
                return null;

            return ouput;
        }
        #endregion

        #region METHODS DECRYPT

        /// <summary>
        /// Decrypt a byte
        /// </summary>
        /// <param name="mInput">byte to decrypt</param>
        /// <param name="mIV">Initialition vector</param>
        /// <returns>Byte decrypted</returns>
        public byte[] DecryptByte(byte[] mInput, byte[] mKeyDecrypter)
        {            
            CAes Aes = new CAes();

            CWolfSsl.ReturnCode rc = Aes.AesCbcDecrypt(mInput, mKeyDecrypter, IV, out byte[] ouput);
            if (rc != CWolfSsl.ReturnCode.Ok)
                return new byte[] { };
         
            return ouput;
        }

        #endregion

        #region METHODS

        private void GenerateIV()
        {
            //Set a new IV for this session
            CRng keys = new CRng();

            keys.GenerateKey(out byte[] mIV, CManager.KEY_LENGTH);
            IV = mIV;
        }

       public byte[] GererateRamdomKEY(int mLength)
        {
            CRng keys = new CRng();
            byte[] NewKey = new byte[mLength];
            keys.GenerateKey(out NewKey, mLength);
            return NewKey;
        }
            

        #endregion
    }
}

