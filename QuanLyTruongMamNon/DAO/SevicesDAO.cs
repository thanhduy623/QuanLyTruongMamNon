using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyTruongMamNon.DAO
{
    public class SevicesDAO
    {
        private static SevicesDAO instance;
        public static SevicesDAO Instance
        {
            get { if (instance == null) instance = new SevicesDAO(); return instance; }
            private set { instance = value; }
        }

        //Thông báo
        internal void Notifications(string id , DateTime date , string tiltes , string cont)
        {
            string query = "INSERT INTO NOTICATION (idNotication , dateNotication , title , content ) VALUES ('" + id + "' , ' " + date + " ' , N'" + tiltes + " ' , N'" + cont + "' );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //Xóa thông báo
        internal void DeleteNoti(string id)
        {
            string query = "Delete from NOTICATION  where idNotication =  '"+ id +"'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //tải danh sách học sinh
        internal Student loadStudent(string id)
        {
            string query = "select * from STUDENTS where idStudent = '" + id + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            Student stu = new Student(result.Rows[0]);
            return stu;
        }
    }
}
