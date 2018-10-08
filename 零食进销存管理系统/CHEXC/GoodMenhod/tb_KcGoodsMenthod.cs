using System;
using System.Collections.Generic;
using System.Text;
        using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
     public  class tb_KcGoodsMenthod
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
         #region Ìí¼Ó
         public int tb_KcGoodsAdd(tb_KcGoods kcGood)
         {
             int intFalg = 0;
             
                 return intFalg;

         }
         #endregion
         #region ÐÞ¸Ä
         public int tb_KcGoodsUpdate(tb_KcGoods kcGood)
         {
             int intFalg = 0;
             
                 return intFalg;



            

         }
        #endregion
         #region
         public int tb_KcGoodsUpdate(string kcGood,int striID)
         {
             int intFalg = 0;
             
                 return intFalg;

           
         }
        #endregion
         #region ²éÑ¯
         public void tb_ThGoodsFind(object DataObject, int intFalg, tb_KcGoods kcGood)
         {
             

         }
         #endregion
         public SqlDataReader tb_ThGoodsFind(string DataObject)
         {
             
             
                 return qlddr;


             

         }
    }
}
