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

        //ʵ����model���� userInfo�����ڴ�������
        Model.userInfo m_userInfo = new Model.userInfo();

        //ʵ����BLL���� userAccess�����ν��û����������ݿ�ƥ��
        BLL.userAccess b_userAccess = new BLL.userAccess();



        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //���û�������˺����� ��ֵ��userInfo�� username��psw����
            m_userInfo.username = textBox1.Text.Trim().ToString();
            m_userInfo.psw = textBox2.Text.Trim().ToString();

            //���BLL���� useLogin���÷��ؼ�¼���� ����1 ���˺�������ȷ
            if (b_userAccess.userLogin(m_userInfo) > 0)
            {
                //���ص�¼����
                this.Hide();
                //��ʾ������
                FrMain fMain = new FrMain();
                fMain.Show();
            }
            else
            {
                MessageBox.Show("��¼ʧ��");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

