package com.insist.jiabei.readingnotes;

import android.app.ListActivity;
import android.content.DialogInterface;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.Toast;

public class BookListActivity extends ListActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_book_list);


        //实例DBHelper
        final DBHelper helper=new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db=helper.getWritableDatabase();
        if((db.rawQuery("Select * from bookInfoTBL", null))==null)
        {
            Toast.makeText(BookListActivity.this, "书籍为空", Toast.LENGTH_SHORT).show();
        }
        else
        {
            Cursor c=helper.query_book();
            //列表项数组
            String[] from={"_id","bookName","author","press","ISBN","className"};
            //列表项id
            int[] to={R.id.bookId,R.id.bookName,R.id.author,R.id.press,R.id.ISBN,R.id.className};
            //适配器
            SimpleCursorAdapter adapter=new SimpleCursorAdapter(this,R.layout.activity_book_list,c,from,to,0);
            //列表视图
            ListView listView=getListView();
            //为列表添加适配器
            listView.setAdapter(adapter);
            //对话框
            final AlertDialog.Builder builder=new AlertDialog.Builder(this);
            //为listview添加监听
            listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                    final long temp=l;
                    builder.setMessage("是否删除这本书籍？").setNegativeButton("是",new DialogInterface.OnClickListener()
                            {
                                @Override
                                public void onClick(DialogInterface dialogInterface, int i) {
                                //删除数据
                            helper.del_book((int)temp);
                            //提示删除成功
                            Toast.makeText(BookListActivity.this, "删除成功", Toast.LENGTH_SHORT).show();
                            //查询
                            Cursor c=helper.query_book();
                            String[] from={"_id","bookName","author","press","ISBN","className"};
                            int[] to={R.id.bookId,R.id.bookName,R.id.author,R.id.press,R.id.ISBN,R.id.className};
                            SimpleCursorAdapter adapter=new SimpleCursorAdapter(getApplicationContext(),R.layout.activity_book_list,c,from,to,0);
                            ListView listView=getListView();
                            listView.setAdapter(adapter);
                        }
                    }).setPositiveButton("否",new DialogInterface.OnClickListener()
                    {
                        public void onClick(DialogInterface dialog,int which){
                        }
                    });
                    //创建提示对话框
                    AlertDialog ad=builder.create();
                    //显示对话框
                    ad.show();
                }
            });
        }

        //关闭数据库
        helper.close();
    }
}
