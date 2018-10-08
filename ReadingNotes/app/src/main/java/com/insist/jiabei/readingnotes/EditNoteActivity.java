package com.insist.jiabei.readingnotes;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.provider.SyncStateContract;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class EditNoteActivity extends AppCompatActivity {

    private Button b;
    private Button r;
    private String bookName;
    private int user_id;
    private int book_id;
    private String date;
    private EditText et;//时间
    private String content;//内容
    private EditText con;

    private Spinner SbookName;
    private List<String> list;
    private ArrayAdapter<String> adapter;
    String username=LoginActivity.username;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_note);

        //接收笔记编号
        Intent intent = getIntent();
        //String name = intent.getStringExtra("name");
        int temp = intent.getIntExtra("temp", 0);
        //float IQ = intent.getFloatExtra("IQ", 0.0f);

        //查找此条笔记的内容
        //实例DBHelper
        final DBHelper helper=new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db=helper.getReadableDatabase();
        Cursor c=helper.query_note_detail(temp);
        if(c.moveToFirst())
        {
            date=c.getString(c.getColumnIndex("noteTBL._id"));
            bookName=c.getString(c.getColumnIndex("bookInfoTBL.bookName"));
            content=c.getString(c.getColumnIndex("noteTBL.content"));
            book_id=c.getInt(c.getColumnIndex("noteTBL.bookId"));
        }
        c.close();

        SbookName=(Spinner)findViewById(R.id.bookName);


        /*设置数据源*/
        list=new ArrayList<String>();

        Cursor c2=helper.query_book();

        //Cursor c=db.rawQuery("select * from bookClassTBL", null);
        while(c2.moveToNext())
        {
            int id=c2.getInt(c.getColumnIndex("_id"));
            String bookName=c2.getString(c.getColumnIndex("bookName"));

            list.add(bookName);
        }
        c2.close();

        /*新建适配器*/
        adapter=new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,list);

        /*adapter设置一个下拉列表样式，参数为系统子布局*/
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_item);

        /*spDown加载适配器*/
        SbookName.setAdapter(adapter);

        //书名的显示
        SbookName.setSelection(book_id-1);


        //时间的显示
        et=(EditText)findViewById(R.id.date);
        et.setText(date);

        //内容的显示
        con=(EditText)findViewById(R.id.content);
        con.setText(content);


        b=(Button)findViewById(R.id.add);


        //添加按钮
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                ContentValues values=new ContentValues();

                //选中的那一项
                bookName=SbookName.getSelectedItem().toString();


                Cursor cursor=helper.query_userId(username);
                //Cursor cursor=db.rawQuery("select _id from userTBL where username="+"'"+username+"'",null);
                if(cursor.moveToFirst())
                {
                    user_id=cursor.getInt(cursor.getColumnIndex(SyncStateContract.Constants._ID));
                    //user_id=cursor.getInt(0);
                }
                cursor.close();

                Cursor cursor1=helper.query_bookId(bookName);
                //int a=cursor1.getCount();
                if(cursor1.moveToFirst())
                {
                    book_id=cursor1.getInt(cursor1.getColumnIndex("_id"));
                    //book_id=cursor1.getInt(0);
                }
                cursor1.close();

                date=et.getText().toString();
                content=((EditText)findViewById(R.id.content)).getText().toString();



                //在values中添加内容
                values.put("_id",date);
                values.put("content",content);
                values.put("userId",user_id);
                values.put("bookId",book_id);

                //实例化数据库类
                DBHelper helper=new DBHelper(getApplicationContext());
                //修改数据
                helper.update_note(values);
                //实例化Intent
                Intent intent=new Intent(EditNoteActivity.this,MyNoteListActivity.class);
                //启动Intent
                Toast.makeText(EditNoteActivity.this, "修改成功", Toast.LENGTH_SHORT).show();
                startActivity(intent);
            }

        });

    }

    //返回按钮
    public void re_Onclick()
    {
        Intent intent=new Intent();
        intent.setClass(EditNoteActivity.this,MyNoteListActivity.class);
        startActivity(intent);
    }

}
