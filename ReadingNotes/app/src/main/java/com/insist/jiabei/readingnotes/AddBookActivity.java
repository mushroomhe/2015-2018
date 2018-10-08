package com.insist.jiabei.readingnotes;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class AddBookActivity extends AppCompatActivity {

    private Button b;
    private String bookName;
    private String author;
    private String press;
    private String ISBN;
    private String className;



    private Spinner SclassName;
    private List<String> list;
    private ArrayAdapter<String> adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_book);

        SclassName=(Spinner) findViewById(R.id.className);

        /*设置数据源*/
        list=new ArrayList<String>();

        //实例DBHelper
        final DBHelper helper=new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db=helper.getReadableDatabase();
        Cursor c=helper.query_bookClass();
        //Cursor c=db.rawQuery("select * from bookClassTBL", null);
        while(c.moveToNext())
        {
            int id=c.getInt(c.getColumnIndex("_id"));
            String className=c.getString(c.getColumnIndex("className"));
            list.add(className);

        }
        c.close();



        /*新建适配器*/
        adapter=new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,list);

        /*adapter设置一个下拉列表样式，参数为系统子布局*/
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_item);

        /*spDown加载适配器*/
        SclassName.setAdapter(adapter);


        //进行添加书籍



        b=(Button)findViewById(R.id.add);


        //添加按钮
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                ContentValues values=new ContentValues();
                //选中的那一项

                bookName=((EditText)findViewById(R.id.bookName)).getText().toString();
                author=((EditText)findViewById(R.id.author)).getText().toString();
                press=((EditText)findViewById(R.id.press)).getText().toString();
                ISBN=((EditText)findViewById(R.id.ISBN)).getText().toString();
                className=SclassName.getSelectedItem().toString();
                //在values中添加内容
                values.put("bookName",bookName);
                values.put("author",author);
                values.put("press",press);
                values.put("ISBN",ISBN);
                values.put("className",className);

                //实例化数据库类
                DBHelper helper=new DBHelper(getApplicationContext());
                //插入数据
                helper.insert_book(values);
                //实例化Intent
                Intent intent=new Intent(AddBookActivity.this,BookActivity.class);
                //启动Intent
                Toast.makeText(AddBookActivity.this, "添加成功", Toast.LENGTH_SHORT).show();
                startActivity(intent);
            }

        });
    }


}
