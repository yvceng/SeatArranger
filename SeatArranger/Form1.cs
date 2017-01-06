using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatArranger
{
    public partial class Form1 : Form
    {
        string[,] rectArr;
        string[] inputArr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            string inputStr = tbInput.Text;
            if (inputStr == "") return;
            else if (tbHeight.Text == "" || tbWidth.Text == "")
                MessageBox.Show("请输入输出长宽");
            else
                SeatCompute(inputStr);
        }
        void SeatCompute(string inputStr)
        {
            #region 读取输入数据到输入数组
            inputStr = inputStr.Replace("\r", "");
            inputArr = inputStr.Split('\n', '\t');
            //使用lambda表达式过滤掉空字符串
            inputArr = inputArr.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            #endregion
            #region 将一维数组填充到矩阵
            //验证数据
            int height = int.Parse(tbHeight.Text);
            int width = int.Parse(tbWidth.Text);
            int sCount = inputArr.Count();
            if (height * width < 2)
            {
                MessageBox.Show("目标区域大小有误。");
                return;
            }
            if (height * width < sCount)
            {
                MessageBox.Show("人数超出区块大小。");
                return;
            }
            //先进行默认方式填充
            rectArr = new string[height, width];
            int i = 0, j = 0;
            foreach (string sname in inputArr)
            {
                if (j >= width)
                {
                    j = 0;
                    i++;
                }
                rectArr[i, j] = sname;
                j++;
            }
            //垂直优先的进行转置
            if (rbVertical.Checked)
            {
                string[,] newRectArr = new string[width, height];
                if (!MatrixInver(rectArr, ref newRectArr)) { MessageBox.Show("转置出错"); return; }
                rectArr = newRectArr;
            }
            #endregion
            PrintMatrix();
            return;
        }
        //矩阵填充
        private void MatrixFill()
        {
            if (rectArr == null) return;
            int sCount = inputArr.Count();
            int height = rectArr.GetLength(0);   //行数·高度
            int width = rectArr.GetLength(1);    //列数·宽度

            rectArr = new string[height, width];
            int i = 0, j = 0;
            foreach (string sname in inputArr)
            {
                if (j >= width)
                {
                    j = 0;
                    i++;
                }
                Point newPoint = CoordinateTransform(new Point(i,j),1);
                //横坐标=起始位置+偏移量*偏移方向
                rectArr[i, (width - 1 >> 1) + (j+1 >> 1) * (2 * (j & 1) - 1)] = sname;
                //rectArr[i, j] = sname;
                j++;
            }
        }
        //坐标转换
        private Point CoordinateTransform(Point input,int sorttype)
        {
            Point np=new Point();
            switch (sorttype)
            {
                case 1:
                    ;
                    break;
                case 2:
                    ;
                    break;
                case 3:
                    ;
                    break;
                default:
                    break;
            }
            return np;
        }
        //将矩阵 rectArr[height,width]输出为文本
        private void PrintMatrix()
        {
            int sCount = inputArr.Count();
            int height = rectArr.GetLength(0);   //行数·高度
            int width = rectArr.GetLength(1);    //列数·宽度
            #region 矩阵输出到字符串
            string outputstr = "";
            int c = sCount;
            for (int i = 0; i < height; i++)
            {
                if (i * width + 1 >= sCount) break; //上一行输出完才判断是否结束
                for (int j = 0; j < width; j++)
                {
                    outputstr += rectArr[i, j];
                    if (j == width - 1)
                    {
                        outputstr += "\r\n";
                        if (cbSpaceLine.Checked) outputstr += "\r\n";
                    }
                    else outputstr += "\t";
                }
            }
            tbOutput.Text = outputstr;
            #endregion
        }

        /// 矩阵的复制  
        public bool MatrixCopy(string[,] a, ref string[,] b)
        {
            if (a.GetLength(0) != b.GetLength(1) || a.GetLength(1) != b.GetLength(0))
                return false;
            for (int i = 0; i < a.GetLength(1); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                    b[i, j] = a[i, j];

            return true;
        }
        /// 矩阵的转置  
        public bool MatrixInver(string[,] a, ref string[,] b)
        {
            if (a.GetLength(0) != b.GetLength(1) || a.GetLength(1) != b.GetLength(0))
                return false;
            for (int i = 0; i < a.GetLength(1); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                    b[i, j] = a[j, i];
            return true;   
        }
        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOutput_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A) tb.SelectAll(); //全选快捷键
        }
        
    }
}
