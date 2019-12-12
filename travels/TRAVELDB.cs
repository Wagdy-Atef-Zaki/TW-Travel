using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace travels
{
    class TRAVELDB
    {

        SqlConnection con;


        public TRAVELDB()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=travel;Integrated Security=true");
        }



        #region customer
        public void insertcustomer(string name,string country,string address,string sort,Int64 idcard,Int64 phone,string email,Int64 tranid)
        {
           
                con.Open();
                SqlCommand com = new SqlCommand("insert into CustomerTB values('" + name + "','" + country + "','" + address + "','" + sort + "'," + idcard + "," + phone + ",'" + email + "'," + tranid + ")", con);
                com.ExecuteNonQuery();
                con.Close();
           
        }
        public void updatecustomer(string name, string country, string address, string sort, Int64 idcard, Int64 phone, string email, Int64 tranid)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update CustomerTB set cust_country='"+country+"',cust_adress='"+address+"',cust_sort='"+sort+"',cust_idcard="+idcard+",cust_phone="+phone+",cust_email='"+email+"',fk_tranid="+tranid+" where cust_name='"+name+"'", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public void deletcustomer( Int64 id)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from CustomerTB where pk_custid='" + id + "'", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public DataTable comboboxedit()
        {
            SqlCommand com = new SqlCommand("select cust_name,pk_custid from CustomerTB",con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_custid",typeof(int));
            DataColumn dc2 = new DataColumn("cust_name",typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;

        }


        public DataTable comboboxdelete()
        {
            SqlCommand com = new SqlCommand("select cust_name,pk_custid from CustomerTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_custid", typeof(int));
            DataColumn dc2 = new DataColumn("cust_name", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;

        }

        public DataTable comboboxfill()
        {
            SqlCommand com = new SqlCommand("select pk_tranid,tran_tripnumber from TransportToolsTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_tranid", typeof(Int64));
            DataColumn dc2 = new DataColumn("tran_tripnumber", typeof(Int64));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }

        public void returndata(string name, ref string country, ref string address, ref string sort, ref Int64 idcard, ref Int64 phone, ref string email,ref Int64 tranid)
        {
            country = ""; address = ""; sort = ""; idcard = 0; phone = 0; email = ""; tranid = 0;
            con.Open();
            SqlCommand com = new SqlCommand("select cust_country,cust_adress,cust_sort,cust_idcard,cust_phone,cust_email,fk_tranid from CustomerTB where cust_name='"+name+"'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                country=dr[0].ToString();
                address=dr[1].ToString();
                sort=dr[2].ToString();
                idcard=Int64.Parse(dr[3].ToString());
                phone=Int64.Parse(dr[4].ToString());
                email=dr[5].ToString();
                tranid=Int64.Parse(dr[6].ToString());
            }
            
            else
            {
                country="null";
                address="null";
                sort="null";
                idcard=0;
                phone=0;
                email = "null";
                tranid=0;

            }
            dr.Close();
            con.Close();
        }


        #endregion




        #region program
     
        public void insertprogram(string name,string datebegin, string dateend, string programs, Int64 travelernum, string hotel, double cost)
        {
           try
           {
                con.Open();
                SqlCommand com = new SqlCommand("insert into ProgrammTravelTB values('" + name + "','" + datebegin + "','" + dateend + "','" + programs + "'," + travelernum + ",'" + hotel + "'," + cost + ")", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch 
            {
                MessageBox.Show("You Have Something Not Entery!!! Please Enter It");
            }
        }
    
        public void updateprogram(string name, string datebegin, string dateend, string programs, Int64 travelernum, string hotel, double cost)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update ProgrammTravelTB set prog_daybegin='" + datebegin + "',prog_dayend='" + dateend + "',prog_programms='" + programs + "',prog_travelernumber=" + travelernum + ",prog_hotel='" + hotel + "',prog_cost=" + cost + " where  prog_name='" + name + "'", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public void deleteprogram(Int64 id)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from ProgrammTravelTB where pk_progid="+id+"", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void tripnumbermethod(ComboBox c1)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select tran_tripnumber from TransportToolsTB",con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                c1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void showprogmethod(ComboBox c2)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select prog_name from ProgrammTravelTB",con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                c2.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
 
        }
      

        public DataTable comboboxshowprog()
        {
            SqlCommand com = new SqlCommand("select pk_progid,prog_name from ProgrammTravelTB ", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_progid", typeof(int));
            DataColumn dc2 = new DataColumn("prog_name", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;

        }
        public void showdatainedit(string name,ref string datebegin,ref string dateend,ref string programs,ref Int64 travelernum,ref string hotel,ref double cost)
        {
            datebegin = ""; dateend = ""; programs = ""; travelernum = 0; hotel = ""; cost = 0;
            con.Open();
            SqlCommand com = new SqlCommand("select prog_daybegin,prog_dayend,prog_programms,prog_travelernumber,prog_hotel,prog_cost from ProgrammTravelTB where prog_name='"+name+"'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                datebegin = dr[0].ToString();
                dateend = dr[1].ToString();
                programs = dr[2].ToString();
                travelernum = Int64.Parse(dr[3].ToString());
                hotel = dr[4].ToString();
                cost = double.Parse(dr[5].ToString());

            }
            else
            {
                datebegin = "";
                dateend = "";
                programs = "null";
                travelernum = 0;
                hotel = "null";
                cost = 0;
            }
            dr.Close();
            con.Close();
 
        }



        #endregion


         
        #region transporttools
        public void inserttransportools(string type, string grade, string takeoff, string arrival, double cost, Int64 tripnum, string system, string direction, Int64 progid)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into TransportToolsTB values('" + type + "','" + grade + "','" + takeoff + "','" + arrival + "'," + cost + "," + tripnum + ",'" + system + "','" + direction + "'," + progid + ")", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public void updatetransporttools(string type, string grade, string takeoff, string arrival, double cost, Int64 tripnum, string system, string direction, Int64 progid)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update TransportToolsTB set tran_type='"+type+"',tran_grade='"+grade+"',tran_timetakingoff='"+takeoff+"',tran_timearrival='"+arrival+"',tran_cost="+cost+",tran_tripsystem='"+system+"',tran_direction='"+direction+"',fk_progid="+progid+" where tran_tripnumber="+tripnum+"",con);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void deletetransporttools(string type,Int64 tripnum)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from TransportToolsTB,CustomerTB where tran_tripnumber="+tripnum+" and tran_type='"+type+"'", con);
            com.ExecuteNonQuery();
            con.Close();
        }


        public DataTable comboboxshowpprogg()
        {
            SqlCommand com = new SqlCommand("select pk_progid,prog_name from ProgrammTravelTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_progid", typeof(int));
            DataColumn dc2 = new DataColumn("prog_name", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }

        public void tripnumber(ComboBox c1)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select tran_tripnumber from TransportToolsTB",con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                c1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }


        public void returntools(Int64 tripnumber, ref string type, ref string grade, ref string timeoff, ref string timearrival, ref double cost, ref string tripsystem, ref string direction,ref Int64 progid)
        {
            type = ""; grade = ""; timeoff = ""; timearrival = ""; cost = 0; tripsystem = ""; direction = ""; progid = 0;
            con.Open();
            SqlCommand com = new SqlCommand("select tran_type,tran_grade,tran_timetakingoff,tran_timearrival,tran_cost,tran_tripsystem,tran_direction,fk_progid from TransportToolsTB where tran_tripnumber="+tripnumber,con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                type = dr[0].ToString();
                grade = dr[1].ToString();
                timeoff = dr[2].ToString();
                timearrival = dr[3].ToString();
                cost = double.Parse(dr[4].ToString());
                tripsystem = dr[5].ToString();
                direction = dr[6].ToString();
                progid = Int64.Parse(dr[7].ToString());
            }
            else
            {
                type = "";
                grade = ""; 
                timeoff =""; 
                timearrival = "";
                cost = 0; 
                tripsystem = ""; 
                direction = "";
                progid = 0;
 
            }
            dr.Close();
            con.Close();
        }
     


        #endregion




        #region employee

        public void insertemployee(string name, string jop, Int64 workhours, Int64 vacations, Int64 passward, double salary, Int64 idcard, string gender, string address, Int64 phone, Int64 age, string qualification, string statue, string email)//+image
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into EmployeeTB values ('" + name + "','" + jop + "',"+passward+"," + workhours + "," + vacations + "," + salary + "," + idcard + ",'" + gender + "','" + address + "'," + phone + "," + age + ",'" + qualification + "','" + statue + "','" + email + "')", con);
            com.ExecuteNonQuery();
            con.Close();

        }


        public void updateemp(Int64 id, string jop, Int64 workhours, Int64 vacations, Int64 passward, double salary, Int64 idcard, string gender, string address, Int64 phone, Int64 age, string qualification, string statue, string email)//+image
        {
            con.Open();
            SqlCommand com = new SqlCommand("update EmployeeTB set emp_jop='"+jop+"',emp_password="+passward+",emp_workhours="+workhours+",emp_vacations="+vacations+",emp_salary="+salary+",emp_idcard="+idcard+",emp_gender='"+gender+"',emp_adress='"+address+"',emp_phone="+phone+",emp_age="+age+",emp_qualification='"+qualification+"',emp_statue='"+statue+"',emp_email='"+email+"' where pk_empid="+id,con);
            com.ExecuteNonQuery();
            con.Close();
        }


        public void deleteemp(string name)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from EmployeeTB where emp_name='"+name+"'",con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataTable comboboxshowempname()
        {
            SqlCommand com = new SqlCommand("select pk_empid,emp_name from EmployeeTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_empid", typeof(int));
            DataColumn dc2 = new DataColumn("emp_name", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }

        public void showinformation(string name,ref string jop,ref Int64 workhours,ref Int64 vacations,ref Int64 passward,ref double salary,ref Int64 idcard,ref string gender,ref string address,ref Int64 phone,ref Int64 age,ref string qualification,ref string statue,ref string email)//image
        {
            jop = ""; workhours = 0; vacations = 0; passward = 0; salary = 0; idcard = 0; gender = ""; address = ""; phone = 0; age = 0; qualification = ""; statue = "";email="";
            con.Open();
            SqlCommand com = new SqlCommand("select emp_jop,emp_password,emp_workhours,emp_vacations,emp_salary,emp_idcard,emp_gender,emp_adress,emp_phone,emp_age,emp_qualification,emp_statue,emp_email from EmployeeTB where emp_name='"+name+"'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                jop = dr[0].ToString();
                passward = Int64.Parse(dr[1].ToString());
                workhours = Int64.Parse(dr[2].ToString());
                vacations = Int64.Parse(dr[3].ToString());              
                salary = double.Parse(dr[4].ToString());
                idcard = Int64.Parse(dr[5].ToString());
                gender = dr[6].ToString();
                address = dr[7].ToString();
                phone = Int64.Parse(dr[8].ToString());
                age = Int64.Parse(dr[9].ToString());
                qualification = dr[10].ToString();
                statue = dr[11].ToString();
                email = dr[12].ToString();
            }
            else 
            {
                jop = "";
                workhours = 0; 
                vacations = 0; 
                passward = 0; 
                salary = 0;
                idcard = 0; 
                gender = "";
                address = "";
                phone = 0;
                age = 0;
                qualification = "";
                statue = "";
                email = "";  
            }
            dr.Close();
            con.Close();
 
        }

      


        #endregion
          



        #region bassword
        public void checkbassword(string jop, string name,ref Int64 password)
        {
            password = 0;
            con.Open();
            SqlCommand com = new SqlCommand("select emp_password from EmployeeTB where emp_name='"+name+"'and emp_jop='"+jop+"'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            { password = Int64.Parse(dr[0].ToString()); }
            else
            {
                password = 0;
            }
            dr.Close();
            con.Close();
        }

        public void okpassword(string jop, string name, ref Int64 password)
        {
            password = 0;
            con.Open();
            SqlCommand com = new SqlCommand("select emp_password from EmployeeTB where emp_name='" + name + "'and emp_jop='" + jop + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                password = Int64.Parse(dr[0].ToString());
            }
            else
            {
                password = 0;
            }
            dr.Close();
            con.Close();
 
        }
        public void updatepass(Int64 passwordd)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update EmployeeTB set emp_password="+passwordd+"",con);
            com.ExecuteNonQuery();
            con.Close();

        }
     
        
        #endregion

        #region Added


        public void deelcusttol(Int64 id,ComboBox c)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select cust_name from CustomerTB where fk_tranid="+id+"", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                c.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        public DataTable method()
        {
            SqlCommand com = new SqlCommand("select tran_tripnumber,fk_tranid from TransportToolsTB,CustomerTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("tran_tripnumber", typeof(Int64));
            DataColumn dc2 = new DataColumn("fk_tranid", typeof(Int64));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
 
        }
        public void deel(Int64 iid)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from CustomerTB where fk_tranid=" + iid + "", con);
            com.ExecuteNonQuery();
            con.Close();
 
        }


        public DataTable combooprog()
        {
            SqlCommand com = new SqlCommand("select pk_progid,prog_name from ProgrammTravelTB", con);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("pk_progid", typeof(Int64));
            DataColumn dc2 = new DataColumn("prog_name", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
        public void deelprog(Int64 idd, ComboBox c1)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select tran_tripnumber from TransportToolsTB where fk_progid=" + idd + "", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                c1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void deelpp(Int64 idd)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete from TransportToolsTB where fk_progid=" + idd + "", con);
            com.ExecuteNonQuery();
            con.Close();

        }
        #endregion
        
    }
}
