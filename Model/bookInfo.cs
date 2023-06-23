using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class bookInfo
    {
        private int _bookID;
        private string _bookName;
        private string _publisher;
        private string _publishDate;
        private int _publishNum;
        private int _words;
        private string _publishWay;
        private float _pride;
        private byte[] _imageByte;

        public int bookID
        {
            get { return _bookID; }
            set { _bookID = value; }
        }
        public string bookName
        { 
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public string publishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
        public int publishNum
        {
            get { return _publishNum; }
            set { _publishNum = value; }
        }
        public int words
        {
            get { return _words; }
            set { _words = value; }
        }
        public string publishWay
        {
            get { return _publishWay; }
            set { _publishWay = value; }
        }
        public float pride
        {
            get { return _pride; }
            set
            {
                _pride = value;
            }
        }
        public byte[] imageByte
        {
            get { return _imageByte; }
            set
            {
                _imageByte = value;
            }
        }
    }
}
