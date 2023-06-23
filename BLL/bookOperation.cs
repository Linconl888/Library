using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bookOperation
    {
        DAL.bookSearch d_bookSearch = new DAL.bookSearch();
        DAL.bookAdd d_bookAdd = new DAL.bookAdd();
        DAL.bookChange d_bookChange = new DAL.bookChange();
        DAL.bookDelete d_bookDelete = new DAL.bookDelete();

        public int SearchNumber(Model.bookInfo m_bookInfo)
        {
            return d_bookSearch.bookSearchNumber(m_bookInfo.bookID, m_bookInfo.bookName,m_bookInfo.publisher,m_bookInfo.publishDate,
                m_bookInfo.publishNum,m_bookInfo.words,m_bookInfo.publishWay,m_bookInfo.pride);
        }

        public int SearchAllNumber(Model.bookInfo m_bookInfo)
        {
            return d_bookSearch.bookSearchAllNumber(m_bookInfo.bookID, m_bookInfo.bookName, m_bookInfo.publisher, m_bookInfo.publishDate,
                m_bookInfo.publishNum, m_bookInfo.words, m_bookInfo.publishWay, m_bookInfo.pride);
        }

        public int BookAddNumber(Model.bookInfo m_bookInfo)
        {
            return d_bookAdd.BookAdd(m_bookInfo.bookID, m_bookInfo.bookName, m_bookInfo.publisher, m_bookInfo.publishDate,
                m_bookInfo.publishNum, m_bookInfo.words, m_bookInfo.publishWay, m_bookInfo.pride);
        }

        public int BookChangeNumber(Model.bookInfo m_bookInfo)
        {
            return d_bookChange.BookChange(m_bookInfo.bookID, m_bookInfo.bookName, m_bookInfo.publisher, m_bookInfo.publishDate,
                m_bookInfo.publishNum, m_bookInfo.words, m_bookInfo.publishWay, m_bookInfo.pride);
        }
        public int BookDeleteNumber(Model.bookInfo m_bookInfo)
        {
            return d_bookDelete.BookDelete(m_bookInfo.bookID);
        }
        public DataSet BookData(Model.bookInfo m_bookInfo)
        {
            return d_bookSearch.bookSearchReasault(m_bookInfo.bookID, m_bookInfo.bookName, m_bookInfo.publisher, m_bookInfo.publishDate,
                m_bookInfo.publishNum, m_bookInfo.words, m_bookInfo.publishWay, m_bookInfo.pride);
        }

        public DataSet Flash(Model.bookInfo m_bookInfo)
        {
            return d_bookSearch.Flash(m_bookInfo.bookID, m_bookInfo.bookName, m_bookInfo.publisher, m_bookInfo.publishDate,
                m_bookInfo.publishNum, m_bookInfo.words, m_bookInfo.publishWay, m_bookInfo.pride);
        }
    }
}
