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

import java.util.ArrayList;
import java.util.List;

public class UserNoteActivity extends AppCompatActivity {

    public static String userName;
    private Button b;
    private static int userId;

    private Spinner SuserName;
    private List<String> list;
    private ArrayAdapter<String> adapter;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_note);

        SuserName=(Spinner)findViewById(R.id.userName);

        /*设置数据源*/
        list=new ArrayList<String>();

        //实例DBHelper
        final DBHelper helper=new DBHelper(this);
        //获得Cursor
        SQLiteDatabase db=helper.getReadableDatabase();
        //查询所有用户
        Cursor c=helper.query_user();
        //Cursor c=db.rawQuery("select * from bookClassTBL", null);
        while(c.moveToNext())
        {
            int id=c.getInt(c.getColumnIndex("_id"));
            String username=c.getString(c.getColumnIndex("username"));
            list.add(username);
        }
        c.close();



        /*新建适配器*/
        adapter=new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,list);

        /*adapter设置一个下拉列表样式，参数为系统子布局*/
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_item);

        /*spDown加载适配器*/
        SuserName.setAdapter(adapter);


        //进行选择用户

        b=(Button)findViewById(R.id.find);


        //选择按钮
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                ContentValues values=new ContentValues();
                //选中的那一项
                userName=SuserName.getSelectedItem().toString();//用户名

                Cursor cc=helper.query_userId(userName);
                if(cc.moveToFirst())
                {
                    userId=cc.getInt(cc.getColumnIndex("_id"));
                }
                cc.close();

                //实例化Intent
                Intent intent=new Intent();
                intent.setClass(UserNoteActivity.this,FindUserNoteActivity.class);
                //intent.putExtra("userId",userId);
                intent.putExtra("username",userName);
                //启动Intent
                Toast.makeText(UserNoteActivity.this, "查找成功", Toast.LENGTH_SHORT).show();
                startActivity(intent);
            }

        });
    }
}
