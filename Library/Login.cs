using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Login : Form
    {

        //实例化model层中 userInfo类用于传递数据
        Model.userInfo m_userInfo = new Model.userInfo();

        //实例化BLL层中 userAccess方法衔接用户输入与数据库匹配
        BLL.userAccess b_userAccess = new BLL.userAccess();



        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给userInfo类 username、psw属性
            m_userInfo.username = textBox1.Text.Trim().ToString();
            m_userInfo.psw = textBox2.Text.Trim().ToString();

            //如果BLL层中 useLogin调用返回记录条数 大于1 则账号密码正确
            if (b_userAccess.userLogin(m_userInfo) > 0)
            {
                //隐藏登录窗口
                this.Hide();
                //显示主窗口
                FrMain fMain = new FrMain();
                fMain.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

