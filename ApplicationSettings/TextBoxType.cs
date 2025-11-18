using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.ApplicationSettings
{
    public class TextBoxType
    {
        private static TextBoxType instance; //khai báo một instance duy nhât trong suốt vòng đời ứng dụng
        public static TextBoxType Instance //nếu instace chưa tồn tại thì tạo mới và trả về instance đó
        {
            get { if (instance == null) instance = new TextBoxType(); return instance; }
            private set { instance = value; }
        }
        private TextBoxType() { } //contructor riêng, khong cho phép tạo từ bên ngoài lớp

        public void TextBoxOnlyNumber(KeyPressEventArgs e) //ngăn chặn các kí tự không phải số 0-9 hoặc các phím điều khiển (backspace, enter)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void TextBoxNotNumber(KeyPressEventArgs e) //chỉ cho phép người dùng nhập chữ cái, space và các phím điều khiển
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void CurrencyType(object sender, EventArgs e) //gắn với sự kiện Validated hoặc Leave để tự động định dạng số thành kiểu tiền tệ
        {
            TextBox textBox1 = sender as TextBox; //lấy ra textbox đã kích hoạt sự kiện
            if (textBox1.Focused == true) //nếu textbox đang không được focus
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
                    nfi.NumberGroupSeparator = ",";
                    double nValue = 0;
                    bool bError = false;
                    try
                    {
                        nValue = double.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowThousands, nfi); //tiến hành parse
                    }
                    catch (System.Exception se)
                    {
                        bError = true;
                        System.Windows.Forms.MessageBox.Show("Error : " + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //if (!bError)
                        {
                            textBox1.Text = string.Format(nfi, "{0:N0}", nValue);
                            textBox1.Select(textBox1.Text.Length, 0);
                        }
                    }
                }
            }
        }
    }
}
