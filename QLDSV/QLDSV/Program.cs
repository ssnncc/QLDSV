using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLDSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection conn = new SqlConnection();//Biết để kết nối SQL, tồn tại xuyên suốt ct
        public static String connstr;//Chứa chuỗi kết nối,chuỗi kết nối connection string để kết nối với csdl , nó bước đầu tiên để thực hiện kết nối
        public static SqlDataReader myReader;
        // những dòng này dùng trong phần tạo connection string ở bên dưới
        public static String servername = "";//Chứa tên server đang làm việc
        public static String username = "";//Chứa  user đang làm việc
        public static String mlogin = "";//Giữ login đang làm việc
        public static String password = "";

        public static String database = "QLDSV";
        
        // để đăng nhập truy vấn dữ liệu thì nó dùng login này để kết nối(hay là tạo link server)
        // vì nó giống nhau trên các phân mảnh là HTKN nối nó sẽ gán cứng vào.
        public static String remotelogin = "HTKN";//Hỗ trợ kết nối từ xa
        public static String remotepassword = "123456";
        // lưu các login và password từ các form khi chương trình chạy.
        public static String mloginDN = "";
        public static String passwordDN = "";
        // 3 mgroup , mHoten, mKhoa dùng để hiển thi thông tin login vào
        // mGroup là mã nhóm quyền khi của login đó đăng nhập vào =>User thuộc nhóm nào
        public static String mGroup = "";
        // mHoten là  họ tên của của login đăng nhập vào 
        public static String mHoten = "";
        public static int mKhoa = 0;////mKhoa cho biết hiện tại khoa ta đăng nhập vô là khoa nào.

        // lưu các đối tượng form Main và form FrmDangNhap để thực hiển xử lý nghiệp vụ chuyển đổi từ frmMain sang frmDangNhap và ngược lại.
        public static Main frmChinh;
        public static FormDN formDN;
        //biến dùng để chứa danh sách các phân mãnh từ viewDSPM (bằng code, ko kéo thả)
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

        // lưu danh sách các nhóm quyền
        public static string[] NhomQuyen = new string[3] { "PGV", "KHOA", "PKTOAN" };
        // hàm thực hiện kết nối tới Database
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        //Hàm hộ trợ chạy sp
        //CHỉ cho đi 1 chiều, chỉ đc xem
        // ExecSqlDataReader tôc độ tải về nhanh hơn ExecSqlDataTable vì đối tượng nó chỉ quam tân chỉ select
        // chỉ duyệt 1 chiều từ trên xuống
        // vì vậy trong nghiệp vụ form báo cáo thì dùng datareader
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);//(chuỗi lệnh để chạy, chạy trên chuỗi knối nào)
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;//Tăng thời gian chạy chương rình lên 10 phút ( Mặc định là 3p)
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myreader = sqlcmd.ExecuteReader();//chạy thành công
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        // tải về cho phép xem xóa sửa ==> tốc độ tải chậm hơn cái ở trên
        // duyệt 2 chiều dưới lên
        // form nhập liệu thì dùng datatable.

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Program.formDN = new FormDN();
            Application.Run(Program.formDN);
        }
    }
}
