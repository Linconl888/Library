using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class FrMain : Form
    {
        //实例化model层中 bookInfo类用于传递数据
        Model.bookInfo m_bookInfo = new Model.bookInfo();

        //实例化BLL层中 bookSearch方法衔接用户输入与数据库匹配
        BLL.bookOperation b_bookOperation = new BLL.bookOperation();

        public FrMain()
        {
            InitializeComponent();
        }


        //重写关闭窗口按钮方法
        protected override void OnClosing(CancelEventArgs e)
        {
            //让用户选择点击
            DialogResult result = MessageBox.Show("是否确认关闭？", "提示",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //判断是否取消事件
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
        int StoI(System.Windows.Forms.TextBox textBox)
        {
            int result = 0;
            if (int.TryParse(textBox.Text, out result))
            {
                return int.Parse(textBox.Text);
            }
            else
            {
                return 0;
            }
        }
        float StoF(System.Windows.Forms.TextBox textBox)
        {
            float result = 0;
            if (float.TryParse(textBox.Text, out result))
            {
                return float.Parse(textBox.Text);
            }
            else
            {
                return 0;
            }
        }

        void init(bookInfo bookInfo)
        {
            m_bookInfo.bookID = StoI(tb_bookID);
            m_bookInfo.publishNum = StoI(tb_publishNum);
            m_bookInfo.words = StoI(tb_words);
            m_bookInfo.pride = StoF(tb_pride);

            m_bookInfo.bookName = tb_bookName.Text;
            m_bookInfo.publisher = tb_publisher.Text;
            m_bookInfo.publishDate = tb_publishDate.Text;
            m_bookInfo.publishWay = tb_publishWay.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            init(m_bookInfo);

            //MessageBox.Show(b_bookOperation.SearchNumber(m_bookInfo).ToString());

            if (b_bookOperation.SearchNumber(m_bookInfo) > 0)
            {
                dataGridView1.DataSource = b_bookOperation.BookData(m_bookInfo).Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("没有查找到相应数据");
                dataGridView1.DataSource = null;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            init(m_bookInfo);
            if (b_bookOperation.BookAddNumber(m_bookInfo) > 0)
            {
                MessageBox.Show("添加成功");
                dataGridView1.DataSource = b_bookOperation.BookData(m_bookInfo).Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("添加失败");
                dataGridView1.DataSource = b_bookOperation.Flash(m_bookInfo).Tables[0].DefaultView;
            }
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            init(m_bookInfo);

            if (b_bookOperation.SearchAllNumber(m_bookInfo) > 0)
            {
                dataGridView1.DataSource = b_bookOperation.Flash(m_bookInfo).Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("数据库中为空");
                dataGridView1.DataSource = null;
            }
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            init(m_bookInfo);
            if (b_bookOperation.BookChangeNumber(m_bookInfo) > 0)
            {
                MessageBox.Show("修改成功");
                dataGridView1.DataSource = b_bookOperation.BookData(m_bookInfo).Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("修改失败");
                dataGridView1.DataSource = b_bookOperation.Flash(m_bookInfo).Tables[0].DefaultView;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            init(m_bookInfo);
            if (b_bookOperation.BookDeleteNumber(m_bookInfo) > 0)
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = b_bookOperation.Flash(m_bookInfo).Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("删除失败");
                dataGridView1.DataSource = b_bookOperation.Flash(m_bookInfo).Tables[0].DefaultView;
            }
        }
    }
}
