using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
    public class tb_EmpInfoMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
       
        #region ���
        public int tb_EmpInfoAdd(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
          
              return intFalg;

        }
        #endregion
        #region �޸�
        public int tb_EmpInfoUpdate(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
          
                return intFalg;


        }
                #endregion
        #region ɾ��
        public int tb_EmpInfoDelete(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
           
                return intFalg;


          

        }
                #endregion
        #region ��ѯ
        public void tb_EmpInfoFind(string strObject,int intFalg,Object DataObject)
        {
            
        }
        #endregion
        #region ��ѯ
        public SqlDataReader tb_EmpInfoFind(string strObject,int intFalg)
        {
           

                return qlddr;


              

        }
            #endregion     
     
        #region ��ѯ
        public int tb_EmpInfoFind(string strObject, string pwwd,int intFalg)
        {
            int intCount = 0;
           

                return intCount;


           
        }
        #endregion
        #region //���ɿͻ���� ���磺KH-20071118114255
        public string tb_EmpInfoID()
        {
            int intYear = DateTime.Now.Day;
            int intMonth = DateTime.Now.Month;
            int intDate = DateTime.Now.Year;
            int intHour = DateTime.Now.Hour;
            int intSecond = DateTime.Now.Second;
            int intMinute = DateTime.Now.Minute;
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


            return ("YG-" + strTime);



        }// end if 
        #endregion


    }
}
