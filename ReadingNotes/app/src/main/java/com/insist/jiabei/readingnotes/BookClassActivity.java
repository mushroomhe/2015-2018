package com.insist.jiabei.readingnotes;

import android.app.ListActivity;
import android.content.ContentValues;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v4.widget.SimpleCursorAdapter;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

public class BookClassActivity extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book_class);
/*

        //实例DBHelper
        final DBHelper helper=new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db=helper.getWritableDatabase();
        if((db.rawQuery("Select * from bookClassTBL", null))==null)
        {
            Toast.makeText(BookClassActivity.this, "书籍分类为空", Toast.LENGTH_SHORT).show();
        }
        else
        {
            Cursor c=helper.query_bookClass();
            //列表项数组
            String[] from={"_id","className"};
            //列表项id
            int[] to={R.id.bookClassId,R.id.bookClassName};
            //适配器
            SimpleCursorAdapter adapter=new SimpleCursorAdapter(this,R.layout.activity_book_class,c,from,to,0);
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
                    builder.setMessage("是否删除此书籍分类？").setNegativeButton("是",new DialogInterface.OnClickListener()
                    {
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i) {
                            //删除数据
                            helper.del_class((int)temp);
                            //查询
                            Cursor c=helper.query_bookClass();
                            String[] from={"_id","className"};
                            int[] to={R.id.bookClassId,R.id.bookClassName};
                            SimpleCursorAdapter adapter=new SimpleCursorAdapter(getApplicationContext(),R.layout.activity_book_class,c,from,to,0);
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
        */
    }

    //点击添加按钮，跳转到添加书籍分类的界面
    protected void Add_Click(View view) {
        Intent intent = new Intent();
        intent.setClass(BookClassActivity.this, AddClassActivity.class);
        startActivity(intent);
    }

    //点击查看按钮，查看此时已添加的书籍分类的界面
    protected void List_Click(View view)
    {
        Intent intent=new Intent();
        intent.setClass(BookClassActivity.this,ClassListActivity.class);
        startActivity(intent);
    }
}
