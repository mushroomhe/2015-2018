using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
    public class tb_CompanyMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
               
        #region 添加
        public int tb_CompanyMenthodAdd(tb_Company Company)
        {
            int intFalg = 0;
            
              return intFalg;

            
            
        }
        #endregion
        #region 修改
        public int tb_CompanyMenthodUpDate(tb_Company Company)
        {
            int intFalg = 0;
           
                return intFalg;



        }
                #endregion
        #region 删除
        public int tb_CompanyMenthodDelete(tb_Company Company)
        {
            int intFalg = 0;
            
                return intFalg;


           

        }
        #endregion
        #region 查询
        public void tb_CompanyFind(string strObject, int intFalg, Object DataObject)
        {
            

        }
        public SqlDataReader tb_CompanyFind(string strObject)
        {
           
            
                return qlddr;
          



        }
           #endregion
        #region //生成客户编号 例如：KH-20071118114255
        public string tb_CustomerID()
        {
            int intYear= DateTime.Now.Day;
            int intMonth=DateTime.Now.Month;
            int intDate=DateTime.Now.Year;
            int intHour=DateTime.Now.Hour;
            int intSecond=DateTime.Now.Second;
           int intMinute=DateTime.Now.Minute;
           string strTime = null;
           strTime = intYear.ToString();
           if (intMonth < 10)
           {
               strTime += "0" + intMonth.ToString();
           }
           else
           {
               strTime += intMonth.ToString();
           }
           if (intDate < 10)
           {
               strTime += "0" + intDate.ToString();
           }
           else
           {
               strTime += intDate.ToString();
           }
           if (intHour < 10)
           {
               strTime += "0" + intHour.ToString();
           }
           else
           {
               strTime += intHour.ToString();
           }
           if (intMinute < 10)
           {

               strTime += "0" + intMinute.ToString();
           }
           else
           {
               strTime += intMinute.ToString();
           }
           if (intSecond < 10)
           {

               strTime += "0" + intSecond.ToString();
           }
           else
           {
               strTime += intSecond.ToString();
           }
            

            return ("KH-" + strTime);


        }// end if 
        #endregion
        #region //填冲商品类别信息 TrreView控件
        public void filltProd(object objTreeView, object obimage)
        {
            

        }// end fi
        #endregion 


    }
}
